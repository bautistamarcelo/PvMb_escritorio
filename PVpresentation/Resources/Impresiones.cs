using BarcodeStandard;
using SkiaSharp;
using System.Drawing.Printing;


namespace PVpresentation.Resources
{
    public class Impresiones
    {

        public int detalleIndex = 0; // Para controlar la posición en la lista
        //FiscalPrinterLib.HASAR ofh = new FiscalPrinterLib.HASAR();

        public void ImprimirPresupuesto(object sender, PrintPageEventArgs e)
        {
            string respuesta = string.Empty;

            #region FUNCIONES PARA NORMALIZAR EL TEXTO A MOSTRAR
            Graphics g = e.Graphics;
            Font fontTitulo = new Font("Arial Narrow", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial Narrow", 10);
            Font fontNegrita = new Font("Arial Narrow", 10, FontStyle.Bold);
            float y = 20;

            int anchoPagina = 300;
            int margenIzquierdo = 20;
            int margenDerecho = 300;

            // Función para centrar texto
            float CentrarTexto(string texto, Font fuente)
            {
                float anchoTexto = g.MeasureString(texto, fuente).Width;
                return margenIzquierdo + (anchoPagina - anchoTexto) / 2;
            }

            // Función para alinear texto a la derecha
            float AlinearDerecha(string texto, Font fuente)
            {
                float anchoTexto = g.MeasureString(texto, fuente).Width;
                return margenIzquierdo + anchoPagina - anchoTexto;
            }

            // Función para dividir el texto en varias líneas dentro de un ancho máximo
            List<string> DividirTexto(string texto, Font fuente, float anchoMaximo)
            {
                List<string> lineas = new List<string>();
                string[] palabras = texto.Split(' ');
                string lineaActual = "";

                using (Graphics g = Graphics.FromImage(new Bitmap(1, 1))) // Objeto gráfico temporal
                {
                    foreach (string palabra in palabras)
                    {
                        string pruebaLinea = lineaActual.Length == 0 ? palabra : lineaActual + " " + palabra;
                        float anchoTexto = g.MeasureString(pruebaLinea, fuente).Width;

                        if (anchoTexto > anchoMaximo)
                        {
                            lineas.Add(lineaActual); // Agrega la línea actual a la lista
                            lineaActual = palabra;   // Inicia una nueva línea con la palabra actual
                        }
                        else
                        {
                            lineaActual = pruebaLinea;
                        }
                    }
                    if (!string.IsNullOrEmpty(lineaActual))
                    {
                        lineas.Add(lineaActual); // Agrega la última línea
                    }
                }
                return lineas;
            }
            #endregion

            #region ENCABEZADO DEL COMPROBANTE 
            //Imprimir encabezado de la empresa centrado
            g.DrawString(VariablesGlobales.EmpresaNombre, fontTitulo, Brushes.Black, CentrarTexto(VariablesGlobales.EmpresaNombre, fontTitulo), y);
            y += 25;
            g.DrawString(VariablesGlobales.oEmpresa.Direccion, fontNormal, Brushes.Black, CentrarTexto(VariablesGlobales.oEmpresa.Direccion, fontNormal), y);
            y += 20;
            g.DrawString(VariablesGlobales.oEmpresa.Telefono, fontNormal, Brushes.Black, CentrarTexto(VariablesGlobales.oEmpresa.Telefono, fontNormal), y);
            y += 30;

            // Línea separadora
            g.DrawLine(Pens.Black, margenIzquierdo, y, margenDerecho, y);
            y += 10;

            // Datos del Comprobante
            g.DrawString("Comprobante N°: " + VariablesGlobales.oVentaE.ID, fontNegrita, Brushes.Black, CentrarTexto("Comprobante N°: " + VariablesGlobales.oVentaE.ID, fontNegrita), y);
            y += 30;

            // Línea separadora
            g.DrawLine(Pens.Black, margenIzquierdo, y, margenDerecho, y);
            y += 10;

            // Datos del cliente
            g.DrawString("Cliente: " + VariablesGlobales.oVentaE.ClienteID.Nombre, fontNegrita, Brushes.Black, margenIzquierdo, y);
            y += 20;
            g.DrawString("Domicilio: " + VariablesGlobales.oVentaE.ClienteID.Domicilio, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 20;
            g.DrawString("CUIT: " + VariablesGlobales.oVentaE.ClienteID.Cuit, fontNormal, Brushes.Black, margenIzquierdo, y);
            y += 30;

            // Línea separadora
            g.DrawLine(Pens.Black, margenIzquierdo, y, margenDerecho, y);
            y += 10;
            #endregion

            #region DETALLE DEL COMPROBANTE
            // Encabezado de la tabla
            g.DrawString("Código", fontNegrita, Brushes.Black, margenIzquierdo, y);
            g.DrawString("Descripción", fontNegrita, Brushes.Black, 70, y);
            g.DrawString("Uds", fontNegrita, Brushes.Black, 160, y);
            g.DrawString("$Unit", fontNegrita, Brushes.Black, 200, y);
            g.DrawString("$Total", fontNegrita, Brushes.Black, 260, y);
            y += 20;

            // **Impresión del detalle de la venta con manejo de paginación**
            int itemsPorPagina = 20;
            int itemsImpresos = 0;

            while (detalleIndex < VariablesGlobales.oVentaE.VentaDetalle.Count)
            {
                var ventaDetalle = VariablesGlobales.oVentaE.VentaDetalle[detalleIndex];

                float alturaLinea = 15; // Espaciado entre líneas
                float anchoDescripcion = 250; // Ancho máximo permitido para la descripción

                // Dividimos la descripción en varias líneas si es necesario
                List<string> lineasDescripcion = DividirTexto(ventaDetalle.ProductoID.Nombre, fontNormal, anchoDescripcion);

                // Determinamos la altura que ocupará el item más alto (descripción más larga)
                int lineasUsadas = lineasDescripcion.Count;
                float alturaItem = lineasUsadas * alturaLinea;

                // Dibujamos el código del producto
                g.DrawString(ventaDetalle.ProductoID.BarCode.ToString(), fontNormal, Brushes.Black, margenIzquierdo, y + 5);

                // Dibujamos la descripción en múltiples líneas
                float yDescripcion = y;// + 5;
                foreach (string linea in lineasDescripcion)
                {
                    g.DrawString(linea, fontNormal, Brushes.Black, 70, yDescripcion);
                    yDescripcion += alturaLinea;
                }
                y += 7;

                // Dibujamos los demás campos alineados con la primera línea de la descripción
                g.DrawString(ventaDetalle.Cantidad.ToString(), fontNormal, Brushes.Black, 160, y += alturaItem);
                g.DrawString(ventaDetalle.pVenta.ToString("0.00"), fontNormal, Brushes.Black, 200, y);
                g.DrawString(ventaDetalle.pTotalVenta.ToString("0.00"), fontNormal, Brushes.Black, AlinearDerecha("$" + ventaDetalle.pTotalVenta.ToString("0.00"), fontNegrita), y);


                // Ajustamos `y` según la altura del item más alto (descripción más larga)
                y += alturaItem + 5;

                detalleIndex++;
                itemsImpresos++;

                // Si alcanzamos el límite de la página, indicamos que hay más páginas
                if (itemsImpresos >= itemsPorPagina)
                {
                    e.HasMorePages = true;
                    return;
                }

            }

            // **Línea separadora**
            g.DrawLine(Pens.Black, margenIzquierdo, y, margenDerecho, y);
            y += 10;
            #endregion

            #region PIE DEL COMPROBANTE
            // **Impresión de Totales**
            g.DrawString("SubTotal: ", fontNegrita, Brushes.Black, 160, y);
            g.DrawString("$" + VariablesGlobales.oVentaE.SubTotal.ToString("0.00"), fontNegrita, Brushes.Black, AlinearDerecha("$" + VariablesGlobales.oVentaE.SubTotal.ToString("0.00"), fontNegrita), y);
            y += 20;

            g.DrawString("Descuento: ", fontNegrita, Brushes.Black, 160, y);
            g.DrawString("$" + VariablesGlobales.oVentaE.DtoEfectivo.ToString("0.00"), fontNegrita, Brushes.Black, AlinearDerecha("$" + VariablesGlobales.oVentaE.DtoEfectivo.ToString("0.00"), fontNegrita), y);
            y += 20;

            g.DrawString("Total: ", fontNegrita, Brushes.Black, 160, y);
            g.DrawString("$" + VariablesGlobales.oVentaE.Monto.ToString("0.00"), fontNegrita, Brushes.Black, AlinearDerecha("$" + VariablesGlobales.oVentaE.Monto.ToString("0.00"), fontNegrita), y);
            y += 30;

            // **Mensaje final**
            g.DrawString("¡Gracias por su visita!", fontNormal, Brushes.Black, CentrarTexto("¡Gracias por su compra!", fontNormal), y);

            // Si no hay más datos, indicar que no hay más páginas
            e.HasMorePages = false;
            detalleIndex = 0; // Resetear índice para futuras impresiones
            #endregion

        }

        public void ImprimirEtiqueta(object sender, PrintPageEventArgs e)
        {
            string respuesta = string.Empty;

            #region FUNCIONES PARA NORMALIZAR EL TEXTO A MOSTRAR
            Graphics g = e.Graphics;
            Font fontBarCode = new Font("IDAHC39MCode39Barcode", 12, FontStyle.Bold);
            Font fontTitulo = new Font("Arial Narrow", 14, FontStyle.Bold);
            Font fontNormal = new Font("Arial Narrow", 10);
            Font fontNegrita = new Font("Arial Narrow", 10, FontStyle.Bold);
            float y = 10;

            int anchoPagina = 200;
            int margenIzquierdo = 10;
            int margenDerecho = 10;

            // Función para centrar texto
            float CentrarTexto(string texto, Font fuente)
            {
                float anchoTexto = g.MeasureString(texto, fuente).Width;
                return margenIzquierdo + (anchoPagina - anchoTexto) / 2;
            }

            // Función para alinear texto a la derecha
            float AlinearDerecha(string texto, Font fuente)
            {
                float anchoTexto = g.MeasureString(texto, fuente).Width;
                return margenIzquierdo + anchoPagina - anchoTexto;
            }

            // Función para dividir el texto en varias líneas dentro de un ancho máximo
            List<string> DividirTexto(string texto, Font fuente, float anchoMaximo)
            {
                List<string> lineas = new List<string>();
                string[] palabras = texto.Split(' ');
                string lineaActual = "";

                using (Graphics g = Graphics.FromImage(new Bitmap(1, 1))) // Objeto gráfico temporal
                {
                    foreach (string palabra in palabras)
                    {
                        string pruebaLinea = lineaActual.Length == 0 ? palabra : lineaActual + " " + palabra;
                        float anchoTexto = g.MeasureString(pruebaLinea, fuente).Width;

                        if (anchoTexto > anchoMaximo)
                        {
                            lineas.Add(lineaActual); // Agrega la línea actual a la lista
                            lineaActual = palabra;   // Inicia una nueva línea con la palabra actual
                        }
                        else
                        {
                            lineaActual = pruebaLinea;
                        }
                    }
                    if (!string.IsNullOrEmpty(lineaActual))
                    {
                        lineas.Add(lineaActual); // Agrega la última línea
                    }
                }
                return lineas;
            }
            #endregion

            #region PRECIOS DE LA ETIQUETA 
            //Imprimir precios del artículo
            g.DrawString("Oferta Cdo.", fontNegrita, Brushes.Black, margenIzquierdo, y);
            string precioOfertaFormateado = VariablesGlobales.vProductoPoferta.ToString("N2");
            g.DrawString(precioOfertaFormateado, fontNegrita, Brushes.Black, 140, y);
            y += 15;
            g.DrawString("Mayorista", fontNormal, Brushes.Black, margenIzquierdo, y);
            string precioVentaFormateado = VariablesGlobales.vProductoPventa.ToString("N2");
            g.DrawString(precioVentaFormateado, fontNormal, Brushes.Black, 140, y);

            // Línea separadora
            g.DrawLine(Pens.Black, margenIzquierdo, y, margenDerecho, y);
            y += 10;

            #endregion

            #region DESCRIPCION DEL PRODUCTO
            // Generar el código de barras

            // 1. Generar el código de barras (usando BarcodeStandard)
            var barcode = new Barcode();
            barcode.IncludeLabel = false; // Mostrar el texto debajo del código
            barcode.Alignment = BarcodeStandard.AlignmentPositions.Center;

            // Configurar el tipo de código (CODE128 es común para productos)
            SKImage skImage = barcode.Encode(
                    BarcodeStandard.Type.Code128,
                    VariablesGlobales.vProductoBarCode.ToString(),
                    SKColors.Black, // Color del código de barras (SKColor)
                    SKColors.White, // Color de fondo (SKColor)
                    180, // Ancho
                    40  // Alto
                );

            // Convertir SKImage a Bitmap (System.Drawing.Image)
            using (SKData data = skImage.Encode(SKEncodedImageFormat.Png, 180))
            using (MemoryStream ms = new MemoryStream(data.ToArray()))
            {
                Bitmap bitmap = new Bitmap(ms);
                e.Graphics.DrawImage(bitmap, new Point(10, 50));
            }
            y += 60;
            // Imprimir el código del producto
            g.DrawString(VariablesGlobales.vProductoBarCode.ToString(), fontNormal, Brushes.Black, 70, y);


            // Si no hay más datos, indicar que no hay más páginas
            e.HasMorePages = false;
            detalleIndex = 0; // Resetear índice para futuras impresiones
            #endregion

        }


    }
}
