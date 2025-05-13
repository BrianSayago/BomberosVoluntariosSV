using System;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class Imprimir
    {
        public void ExportaPDF(DataGridView dgv, string Planilla)
        {
            // Configura el documento PDF
            using (PdfWriter writer = new PdfWriter(Planilla))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    // Agrega un título al PDF
                    document.Add(new Paragraph("Exportación de DataGridView").SetBold().SetFontSize(20));
                    // Agrega una tabla con las mismas columnas que el DataGridView
                    Table table = new Table(dgv.Columns.Count);
                    // Agrega los encabezados de columna
                    foreach (DataGridViewColumn column in dgv.Columns)
                    {
                        table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                    }
                    // Agrega las primeras 100 filas
                    int rowCount = Math.Min(100, dgv.Rows.Count);
                    for (int i = 0; i < rowCount; i++)
                    {
                        DataGridViewRow row = dgv.Rows[i];
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(cell.Value?.ToString() ?? "")));
                        }
                    }
                    // Agrega la tabla al documento
                    document.Add(table);
                }
            }
        }
















    }
  }
