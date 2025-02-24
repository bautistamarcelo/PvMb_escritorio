using System.Drawing.Printing;
using FiscalPrinterLib;

namespace PVpresentation.Resources
{
    public class Impresiones
    {
        
        public int detalleIndex = 0; // Para controlar la posición en la lista
        FiscalPrinterLib.HASAR ofh = new FiscalPrinterLib.HASAR();

        public void ImprimirPresupuesto(object sender, PrintPageEventArgs e)
        {
            string respuesta= string.Empty;

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
                g.DrawString(ventaDetalle.ProductoID.ID.ToString(), fontNormal, Brushes.Black, margenIzquierdo, y + 5);

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
                g.DrawString(ventaDetalle.pTotalVenta.ToString("0.00"), fontNormal, Brushes.Black, 260, y);

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

       

        public void MostrarOpcionesFiscales(object sender, EventArgs e)
        {
            string Salida ="";

            Int32 n;                    // Para mostrar números de comprobantes
            Int32 monto;                // Para mostrar montos

            object nrocomp;             // Argumento de salida CerrarComprobanteFiscal() y CerrarDNFH()

            object items;               // Argumento de salida Subtotal()
            object ventas;              // Argumento de salida Subtotal(), ReporteX(), ReporteZ()
            object iva;                 // Argumento de salida Subtotal()
            object pagado;              // Argumento de salida Subtotal()
            object ivanoi;              // Argumento de salida Subtotal()
            object impint;              // Argumento de salida Subtotal()

            object nrox;                // Argumento de salida ReporteX() / ReporteZ()
            object dfcancel;            // Argumento de salida ReporteX() / ReporteZ()
            object dnfhemit;            // Argumento de salida ReporteX() / ReporteZ()
            object dnfemit;             // Argumento de salida ReporteX() / ReporteZ()
            object dfemit;              // Argumento de salida ReporteX() / ReporteZ()
            object ultdfbc;             // Argumento de salida ReporteX() / ReporteZ()
            object ultdfa;              // Argumento de salida ReporteX() / ReporteZ()
            object ivadf;               // Argumento de salida ReporteX() / ReporteZ()
            object impintdf;            // Argumento de salida ReporteX() / ReporteZ()
            object percepdf;            // Argumento de salida ReporteX() / ReporteZ()
            object ivanoidf;            // Argumento de salida ReporteX() / ReporteZ()
            object ultncbc;             // Argumento de salida ReporteX() / ReporteZ()
            object ultnca;              // Argumento de salida ReporteX() / ReporteZ()
            object ventasnc;            // Argumento de salida ReporteX() / ReporteZ()
            object ivanc;               // Argumento de salida ReporteX() / ReporteZ()
            object impintnc;            // Argumento de salida ReporteX() / ReporteZ()
            object percepnc;            // Argumento de salida ReporteX() / ReporteZ()
            object ivanoinc;            // Argumento de salida ReporteX() / ReporteZ()
            object ultrto;              // Argumento de salida ReporteX() / ReporteZ()
            object cantnccancel;        // Argumento de salida ReporteX() / ReporteZ()
            object cantdfbcemit;        // Argumento de salida ReporteX() / ReporteZ()
            object cantdfaemit;         // Argumento de salida ReporteX() / ReporteZ()
            object cantncbcemit;        // Argumento de salida ReporteX() / ReporteZ()
            object cantncaemit;         // Argumento de salida ReporteX() / ReporteZ()

            // Se declaran todos los eventos posibles de ser disparados por el OCX Fiscal HASAR
            //---------------------------------------------------------------------------------
            //ofh.ErrorFiscal += new FiscalPrinterLib._FiscalEvents_ErrorFiscalEventHandler(ofh_ErrorFiscal);
            //ofh.ErrorImpresora += new FiscalPrinterLib._FiscalEvents_ErrorImpresoraEventHandler(ofh_ErrorImpresora);
            // ofh.EventoCajon += new FiscalPrinterLib._FiscalEvents_EventoCajonEventHandler(ofh_EventoCajon);
            // ofh.EventoFiscal += new FiscalPrinterLib._FiscalEvents_EventoFiscalEventHandler(ofh_EventoFiscal);
            // ofh.EventoImpresora += new FiscalPrinterLib._FiscalEvents_EventoImpresoraEventHandler(ofh_EventoImpresora);
            //ofh.FaltaPapel += new FiscalPrinterLib._FiscalEvents_FaltaPapelEventHandler(ofh_FaltaPapel);
            //ofh.ImpresoraNoResponde += new FiscalPrinterLib._FiscalEvents_ImpresoraNoRespondeEventHandler(ofh_ImpresoraNoResponde);
            // ofh.ImpresoraOcupada += new FiscalPrinterLib._FiscalEvents_ImpresoraOcupadaEventHandler(ofh_ImpresoraOcupada);
            // ofh.ImpresoraOK += new FiscalPrinterLib._FiscalEvents_ImpresoraOKEventHandler(ofh_ImpresoraOK);
            //ofh.ProgresoDeteccion += new FiscalPrinterLib._FiscalEvents_ProgresoDeteccionEventHandler(ofh_ProgresoDeteccion);

            try  // Porción de código para atrapar excepciones...
            {
                ofh.Modelo = FiscalPrinterLib.ModelosDeImpresoras.MODELO_P441;
                ofh.Puerto = 7;
                ofh.Comenzar();
                ofh.TratarDeCancelarTodo();

                //-----------------------------------------------
                // Ejemplo de impresión de un tique factura "A"
                //-----------------------------------------------     
                ofh.DatosCliente("Bautista Marcelo Ricardo...", "20-21159601-6", FiscalPrinterLib.TiposDeDocumento.TIPO_CUIT, FiscalPrinterLib.TiposDeResponsabilidades.RESPONSABLE_INSCRIPTO, "B° Privado Alto Verde 1 - Mz. L - Casa 30");
                ofh.AbrirComprobanteFiscal(FiscalPrinterLib.DocumentosFiscales.TICKET_FACTURA_A);
                ofh.ImprimirItem("Articulo N°1 de 3 a imprimir", 2.0, 30.0, 21.0, 0.0);
                ofh.ImprimirItem("Articulo N°2 de 3 a imprimir", 1.0, 10.0, 21.0, 0.0);
                ofh.ImprimirItem("Articulo N°3 de 3 a imprimir", 4.0, 15.0, 21.0, 0.0);
                ofh.Subtotal(false, out items, out ventas, out iva, out pagado, out ivanoi, out impint);

                monto = System.Int32.Parse(ventas.ToString());
                MessageBox.Show("Subtotal Comprobante ::: $ " + monto.ToString());

                ofh.CerrarComprobanteFiscal(1, out nrocomp);

                n = System.Int32.Parse(nrocomp.ToString());
                MessageBox.Show("Nro. de Comprobante ::: TFA" + " ::: " + n.ToString());

                //-----------------------------------------------------
                // Ejemplo de impresión de un tique nota de crédito "B"
                //-----------------------------------------------------
                ofh.DatosCliente("Razón social cliente...", "12345678", FiscalPrinterLib.TiposDeDocumento.TIPO_DNI, FiscalPrinterLib.TiposDeResponsabilidades.CONSUMIDOR_FINAL, "Domiclio Cliente...");
                ofh.set_DocumentoDeReferencia(1, "TFA 0001-00000876");
                ofh.AbrirDNFH(FiscalPrinterLib.DocumentosNoFiscales.TICKET_NOTA_CREDITO_B);
                ofh.ImprimirItem("Art. Vendido...", 1.0, 10.0, 21.0, 0.0);
                ofh.ImprimirItem("Art. Vendido...", 1.0, 10.0, 21.0, 0.0);
                ofh.Subtotal(false, out items, out ventas, out iva, out pagado, out ivanoi, out impint);

                monto = System.Int32.Parse(ventas.ToString());
                MessageBox.Show("Subtotal Comprobante ::: $ " + monto.ToString());

                ofh.CerrarDNFH(1, out nrocomp);

                n = System.Int32.Parse(nrocomp.ToString());
                MessageBox.Show("Nro. de Comprobante ::: TNCB" + " ::: " + n.ToString());

                //-----------------------------------------------
                // Ejemplo de impresión de un documento no fiscal
                //-----------------------------------------------
                ofh.AbrirComprobanteNoFiscal();
                ofh.ImprimirTextoNoFiscal("Línea de texto no fiscal...");
                ofh.CerrarComprobanteNoFiscal();

                //------------------------------------------------
                // Ejemplo de impresión de un reporte "X"
                //------------------------------------------------
                ofh.ReporteX(out nrox, out dfcancel, out dnfhemit, out dnfemit, out dfemit, out ultdfbc, out ultdfa, out ventas, out ivadf, out impintdf, out percepdf, out ivanoidf, out ultncbc, out ultnca, out ventasnc, out ivanc, out impintnc, out percepnc, out ivanoinc, out ultrto, out cantnccancel, out cantdfbcemit, out cantdfaemit, out cantncbcemit, out cantncaemit);

                n = System.Int32.Parse(ventas.ToString());
                MessageBox.Show("Parcial Ventas ::: Reporte X ::: $ " + n.ToString());

                // Se cierra el puerto serie abierto con 'Comenzar()'...
                ofh.Finalizar();
            }
            catch (SystemException exc)  // Tratamiento de las excepciones disparadas...
            {
                MessageBox.Show(exc.Source + "  :::  " + exc.Message);
            }
            
        }


    }
}
