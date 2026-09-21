using System.Drawing.Imaging;
using Movers_Maintenance_Subsystem.Models;

namespace Movers_Maintenance_Subsystem.AdditionalForms.Reports
{
    public class ReportToPage
    {
        public void PrettyPrintReport(string outputPath, Dictionary<string, string> data)
        {
            //Making the dim
            int pageWidth = 800;
            int pageHeight = 1000;
            Bitmap reportBitmap = new Bitmap(pageWidth, pageHeight);
            Graphics graphics = Graphics.FromImage(reportBitmap);

            // Set background color
            graphics.Clear(Color.White);

            // Set up fonts and brushes
            System.Drawing.Font titleFont = new("Arial", 20, FontStyle.Bold);
            System.Drawing.Font labelFont = new("Arial", 14, FontStyle.Bold);
            System.Drawing.Font valueFont = new("Arial", 14);
            SolidBrush textBrush = new SolidBrush(Color.Black);

            // Report title
            string reportTitle = "Application Report";
            SizeF titleSize = graphics.MeasureString(reportTitle, titleFont);
            float titleX = (pageWidth - titleSize.Width) / 2;
            graphics.DrawString(reportTitle, titleFont, textBrush, titleX, 20);

            // Data display
            float currentY = 80;
            foreach (var pair in data)
            {
                string label = pair.Key + ":";
                string value = pair.Value;

                SizeF labelSize = graphics.MeasureString(label, labelFont);
                SizeF valueSize = graphics.MeasureString(value, valueFont);

                graphics.DrawString(label, labelFont, textBrush, 50, currentY);
                graphics.DrawString(value, valueFont, textBrush, 50 + labelSize.Width + 10, currentY);

                currentY += Math.Max(labelSize.Height, valueSize.Height) + 10; // Add some spacing
            }

            // Add a simple border
            Pen borderPen = new Pen(Color.Black, 2);
            graphics.DrawRectangle(borderPen, 10, 10, pageWidth - 20, pageHeight - 20);

            // Save the report as an image
            reportBitmap.Save(outputPath, ImageFormat.Png);
            ReportDisplay reportDisplay = new ReportDisplay();
            reportDisplay.GetPicture(reportBitmap);
            reportDisplay.ShowDialog();
            

            // Cleanup
            graphics.Dispose();
            reportBitmap.Dispose();
            borderPen.Dispose();
            textBrush.Dispose();
            titleFont.Dispose();
            labelFont.Dispose();
            valueFont.Dispose();
        }

        public static void CallMe<T>(List<T> list, T orderingBy, int? xtraInfo) where T : Model
        {
            ReportToPage generator = new ReportToPage();


            Dictionary<string, string> reportData = new Dictionary<string, string>
            {
                { "Report Date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                { "Application Version", "1.0.0" },
                { "Operating System", Environment.OSVersion.ToString() }
            };
            if (orderingBy is Staff)
            {
                DictionaryAddition(reportData, list as List<Staff>, orderingBy as Staff);
            }
            else if (orderingBy is Van)
            {
                DictionaryAddition(reportData, list as List<Van>, orderingBy as Van);
            }
            else if (orderingBy is Checkup)
            {
                DictionaryAddition(reportData, list as List<Checkup>, orderingBy as Checkup, (int)xtraInfo);
            }
            string DebugPath = Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = Path.GetDirectoryName(DebugPath);
            string outputPath = $"{dataDirectoryPath}report.png";
            generator.PrettyPrintReport(outputPath, reportData);

            Console.WriteLine($"Report generated at: {outputPath}");
        }

        private static Dictionary<string, string> DictionaryAddition(Dictionary<string, string> dict, List<Staff> list, Staff orderingBy)
        {
            int count = 0;
            foreach (Staff s in list)
            {
                if (s.Position == orderingBy.Position)
                {
                    count++;
                    dict.Add($"Staff Member {s.Forename} {s.Surname} ID: {s.StaffID}", $"Works {s.Working_Hours} per week, earning £{s.Hourly_Salary} with the position of {s.Position}.");
                }
            }
            if (count > 0)
            {
                return dict;
            }
            else
            {
                dict.Add("Staff Member", "No staff found.");
            }
            return dict;
        }
        private static Dictionary<string, string> DictionaryAddition(Dictionary<string, string> dict, List<Van> list, Van orderingBy)
        {
            int count = 0;
            foreach (Van v in list)
            {
                if (v.DriverID == orderingBy.DriverID)
                {
                    string InUse = "";
                    count++;
                    if(v.Is_In_Use)
                    {
                        InUse = "in active use";
                        dict.Add($"Van Model {v.Van_Make} ID: {v.VanID}", $"Van is currently {InUse}, and the MOT will expire at the date: {v.MOT_Expiry_Date}, the van driven by the staff member with the id: {v.DriverID}.");
                    }
                    else
                    {
                        InUse = "not in active use";
                        dict.Add($"Van Model {v.Van_Make} ID: {v.VanID}", $"Van is currently {InUse}, the MOT will/has expire(d) at the date: {v.MOT_Expiry_Date}, the van (was) driven by the staff member with the id: {v.DriverID}.");
                    }
                    
                }
            }
            if (count > 0)
            {
                return dict;
            }
            else
            {
                dict.Add("Van", "No van found.");

                return dict;
            }
        }
        private static Dictionary<string, string> DictionaryAddition(Dictionary<string, string> dict, List<Checkup> list, Checkup orderingBy, int sorter)
        {
            int count = 0;
            
            switch(sorter)
            {
                case 1:
                    {
                        foreach (Checkup c in list)
                        {
                            if (DateTime.Compare(c.Checkup_Date, orderingBy.Checkup_Date) < 0)
                            {
                                count++;
                                if (c.IsMoTCheckup)
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup to ensure the van is up to date for its MOT.");
                                }
                                else
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup is just a general maintenance checkup.");
                                }
                            }
                        }
                    }
                    break;
                case 2:
                    {
                        foreach (Checkup c in list)
                        {
                            if (DateTime.Compare(c.Checkup_Date, orderingBy.Checkup_Date) > 0)
                            {
                                if (c.IsMoTCheckup)
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup to ensure the van is up to date for its MOT.");
                                }
                                else
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup is just a general maintenance checkup.");
                                }
                                count++;
                            }
                        }
                    }
                    break;
                case 3:
                    {
                        foreach (Checkup c in list)
                        {
                            if (DateTime.Compare(c.Checkup_Date, orderingBy.Checkup_Date) == 0)
                            {
                                if (c.IsMoTCheckup)
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup to ensure the van is up to date for its MOT.");
                                }
                                else
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup is just a general maintenance checkup.");
                                }
                                count++;
                            }
                        }
                    }
                    break;
                case 4:
                    {
                        foreach (Checkup c in list)
                        {
                            if (DateTime.Compare(c.Checkup_Date, orderingBy.Checkup_Date) <= 0)
                            {
                                if (c.IsMoTCheckup)
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup to ensure the van is up to date for its MOT.");
                                }
                                else
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup is just a general maintenance checkup.");
                                }
                                count++;
                            }
                        }
                    }
                    break;
                case 5:
                    {
                        foreach (Checkup c in list)
                        {
                            if (DateTime.Compare(c.Checkup_Date, orderingBy.Checkup_Date) >= 0)
                            {
                                if (c.IsMoTCheckup)
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup to ensure the van is up to date for its MOT.");
                                }
                                else
                                {
                                    dict.Add($"Checkup - ID: {c.CheckupID}", $"The id van the checkup was servicing is {c.VanID}, the id of the mechanic is {c.MechanicID} - the condition of the van is: {c.Van_Condition}. The date of the checkup is {c.Checkup_Date} - and the checkup is just a general maintenance checkup.");
                                }
                                count++;
                            }
                        }
                    }
                    break;
            }
            if (count > 0)
            {
                return dict;
            }
            else
            {
                dict.Add("Checkup", "No checkup found.");

                return dict;
            }
        }
    }
}
