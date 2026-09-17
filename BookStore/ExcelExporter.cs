using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookStore
{
    public static class ExportHelper
    {
        public static bool ExportToCsv(DataGridView dgv, string defaultFileName = "report")
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv|Excel файлы (*.xls)|*.xls",
                FileName = $"{defaultFileName}_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                Title = "Сохранить отчет"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return false;

            try
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                {
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(dgv.Columns[i].HeaderText);
                        if (i < dgv.Columns.Count - 1)
                            sw.Write(";");
                    }
                    sw.WriteLine();

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            string value = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                            value = value.Replace(";", ",").Replace("\n", " ").Replace("\r", " ");
                            sw.Write(value);
                            if (j < dgv.Columns.Count - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show($"Экспорт завершен!\n{saveDialog.FileName}\n\nФайл можно открыть в Excel.",
                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool ExportBooksAndOrders(DataGridView dgvBooks, DataGridView dgvOrders)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "CSV файлы (*.csv)|*.csv",
                FileName = $"Книжный_магазин_полный_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                Title = "Сохранить отчет"
            };

            if (saveDialog.ShowDialog() != DialogResult.OK)
                return false;

            try
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName, false, Encoding.UTF8))
                {
                    sw.WriteLine("=== КНИГИ ===");
                    for (int i = 0; i < dgvBooks.Columns.Count; i++)
                    {
                        sw.Write(dgvBooks.Columns[i].HeaderText);
                        if (i < dgvBooks.Columns.Count - 1) sw.Write(";");
                    }
                    sw.WriteLine();

                    for (int i = 0; i < dgvBooks.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBooks.Columns.Count; j++)
                        {
                            string value = dgvBooks.Rows[i].Cells[j].Value?.ToString() ?? "";
                            value = value.Replace(";", ",").Replace("\n", " ").Replace("\r", " ");
                            sw.Write(value);
                            if (j < dgvBooks.Columns.Count - 1) sw.Write(";");
                        }
                        sw.WriteLine();
                    }

                    sw.WriteLine();
                    sw.WriteLine("=== ЗАКАЗЫ ===");
                    for (int i = 0; i < dgvOrders.Columns.Count; i++)
                    {
                        sw.Write(dgvOrders.Columns[i].HeaderText);
                        if (i < dgvOrders.Columns.Count - 1) sw.Write(";");
                    }
                    sw.WriteLine();

                    for (int i = 0; i < dgvOrders.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvOrders.Columns.Count; j++)
                        {
                            string value = dgvOrders.Rows[i].Cells[j].Value?.ToString() ?? "";
                            value = value.Replace(";", ",").Replace("\n", " ").Replace("\r", " ");
                            sw.Write(value);
                            if (j < dgvOrders.Columns.Count - 1) sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show($"Экспорт завершен!\n{saveDialog.FileName}\n\nФайл можно открыть в Excel.", "Успех");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта: {ex.Message}", "Ошибка");
                return false;
            }
        }








    }
}