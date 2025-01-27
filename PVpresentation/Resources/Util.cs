using PVrepository.Entities;
using System.Security.Cryptography;
using System.Text;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace PVpresentation.Resources
{
    public static class Util
    {
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++)
                sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static byte[] GeneratePDFventa(Empresa oEmpresa, Sucursales oSucursales, Ventas_E oVenta_E, Stream ImagenLogo)
        {
            QuestPDF.Settings.License= LicenseType.Community;
            var arrayPDF = Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(25);
                    page.Header().ShowOnce().Row(row =>
                    {
                        row.AutoItem().Height(60).Image(ImagenLogo, ImageScaling.FitArea);

                        row.RelativeItem().Column(column =>
                        {
                            column.Item().AlignCenter().Text(oEmpresa.Nombre).Bold().FontSize(14);
                            column.Item().AlignCenter().Text(oEmpresa.Direccion).FontSize(12);
                            column.Item().AlignCenter().Text(oEmpresa.Telefono).FontSize(12);

                        });

                        row.ConstantItem(140).Column(column =>
                        {
                            column.Item().Border(1).BorderColor("#2d425b").AlignCenter().Text($"CUIT: {oEmpresa.Cuit}").Bold().FontSize(14);
                            column.Item().Background("#2d425b").Border(1).BorderColor("#2d425b").AlignCenter().Text("PRESUPUESTO").Bold().FontSize(14).FontColor("#FFF");
                            column.Item().AlignCenter().Text($"N° 0001-000{oVenta_E.ID}").FontSize(12);
                            column.Item().AlignCenter().Text("Fecha: 01/01/2021").FontSize(12);
                        });


                    });

                    page.Content().PaddingVertical(15).Column(column =>
                    {
                        column.Spacing(10);
                        column.Item().LineHorizontal(0.5f);
                        column.Item().Row(row =>
                        {
                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Cliente: ").SemiBold().FontSize(10);
                                txt.Span(oVenta_E.ClienteID.Nombre).FontSize(12);
                            });
                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Fecha: ").SemiBold().FontSize(10);
                                txt.Span(oVenta_E.Fecha.ToString()).FontSize(12);
                            });

                        });

                        column.Item().LineHorizontal(0.5f);
                        column.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(3);
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                                columns.RelativeColumn();
                            });
                            table.Header(header =>
                            {
                                header.Cell().Background("#2d425b").Padding(2).Text("Producto").FontColor("#fff");
                                header.Cell().Background("#2d425b").Padding(2).Text("Precio").Bold();
                                header.Cell().Background("#2d425b").Padding(2).Text("Cantidad").Bold();
                                header.Cell().Background("#2d425b").Padding(2).Text("Total").Bold();
                            });

                            foreach (Ventas_D item in oVenta_E.VentaDetalle)
                            {
                                table.Cell().BorderBottom(0.5f).BorderColor("#2d425b").Padding(2)
                                .Text(item.ProductoID.Nombre).FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#2d425b").Padding(2)
                                .Text(item.pVenta.ToString()).FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#2d425b").Padding(2)
                                .Text(item.Cantidad.ToString()).FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#2d425b").Padding(2)
                                .Text(item.pTotalVenta.ToString()).FontSize(10);

                            }


                        });

                        column.Item().LineHorizontal(0.5f);
                        column.Item().AlignRight().Text($"Total: {oVenta_E.Monto}").FontSize(12).Bold();
                    });

                    page.Footer().AlignRight().Text(txt =>
                    {
                        txt.Span("Página ").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();
            return arrayPDF;
        }
    }
}
