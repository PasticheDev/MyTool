using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace MyTool
{
    
    /// <summary>
    /// Interaktionslogik für Wochenplan.xaml
    /// </summary>
    public partial class Wochenplan : Window
    {
       
        
        public Wochenplan()
        {
            InitializeComponent();
            
        }
        

        private void btn_speichern_Click(object sender, RoutedEventArgs e)
        {
            // Ein Array vom Typ "textbox" in welchem alle textboxen liegen um später durch iterieren zu können
            #region tbArr
            TextBox[] tbArr = { tb_1, tb_2, tb_3, tb_4, tb_5, tb_6, tb_7, tb_8, tb_9, tb_10, tb_11, tb_12, tb_13, tb_14, tb_15, tb_16, tb_17, tb_18, tb_19, tb_20, tb_21, tb_22, tb_23, tb_24, tb_25, tb_26, tb_27, tb_28, tb_29, tb_30, tb_31, tb_32, tb_33, tb_34, tb_35, tb_36, tb_37, tb_38, tb_39, tb_40, tb_41, tb_42, tb_43, tb_44, tb_45, tb_46, tb_47, tb_48, tb_49, tb_50, tb_51, tb_52, tb_53, tb_54, tb_55, tb_56, tb_57, tb_58, tb_59, tb_60, tb_61, tb_62, tb_63, tb_64, tb_65, tb_66, tb_67, tb_69, tb_70, tb_71, tb_72, tb_73, tb_74, tb_75, tb_76, tb_77, tb_78, tb_79, tb_80, tb_81, tb_82, tb_83, tb_84, tb_85, tb_86, tb_87, tb_88, tb_89, tb_90, tb_91, tb_92, tb_93, tb_94, tb_95, tb_96, tb_97, tb_98, tb_99, tb_100, tb_101, tb_102, tb_103, tb_104, tb_105, tb_106 };
            #endregion
            #region Speichervorgan
            // filestream wird geöffnet und automatisch geschlossen - terminplan.txt wird im bin/debug ordner erstellt, filemode create um sicherzustellen, dass die datei immer neu erstellt wird und die alte version überschreibt. Dies ist gewünscht.
            using (FileStream fs = new FileStream("Terminplan.txt", FileMode.Create))
            {
                // Abfangen von eventuellen fehlern
                try
                {
                    // Streamwriter instanz initialisiert und der filestream übergeben.
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        // Iteration durch das textbox-array, jedes element übergibt per .text den Inhalt der Textboxen an den streamwriter.WriteLine
                        foreach(TextBox tb in tbArr)
                        {
                            sw.WriteLine(tb.Text);
                        }
                    }
                    


                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               
            }
            #endregion
            #region Farbverwaltung
            // Initialisierung des Brushconverters um mit den Farbcodes zu arbeiten
            var bc = new BrushConverter();

            // Iterieren durch alle Textboxelemente
            foreach (TextBox tb in tbArr)
            {
                // Wenn Textbox nicht leer, dann ist der Hintergrund rötlich
                if (tb.Text != "")
                {
                    tb.Background = (Brush)bc.ConvertFrom("#f76c7f");
                }
                // Wenn Textbox leer, dann ist der Hintergrund grünlich
                else
                {
                    tb.Background = (Brush)bc.ConvertFrom("#90ee8d");
                }
            }
            #endregion
        }

        private void btn_laden_Click(object sender, RoutedEventArgs e)
        {
            #region tbArr
            TextBox[] tbArr = { tb_1, tb_2, tb_3, tb_4, tb_5, tb_6, tb_7, tb_8, tb_9, tb_10, tb_11, tb_12, tb_13, tb_14, tb_15, tb_16, tb_17, tb_18, tb_19, tb_20, tb_21, tb_22, tb_23, tb_24, tb_25, tb_26, tb_27, tb_28, tb_29, tb_30, tb_31, tb_32, tb_33, tb_34, tb_35, tb_36, tb_37, tb_38, tb_39, tb_40, tb_41, tb_42, tb_43, tb_44, tb_45, tb_46, tb_47, tb_48, tb_49, tb_50, tb_51, tb_52, tb_53, tb_54, tb_55, tb_56, tb_57, tb_58, tb_59, tb_60, tb_61, tb_62, tb_63, tb_64, tb_65, tb_66, tb_67, tb_69, tb_70, tb_71, tb_72, tb_73, tb_74, tb_75, tb_76, tb_77, tb_78, tb_79, tb_80, tb_81, tb_82, tb_83, tb_84, tb_85, tb_86, tb_87, tb_88, tb_89, tb_90, tb_91, tb_92, tb_93, tb_94, tb_95, tb_96, tb_97, tb_98, tb_99, tb_100, tb_101, tb_102, tb_103, tb_104, tb_105, tb_106 };
            #endregion
            #region Ladevorgang
            using (FileStream fs = new FileStream("Terminplan.txt", FileMode.OpenOrCreate))
            {
                // Abfangen von eventuellen fehlern
                try
                {
                    // StreamReader instanz initialisiert und der filestream übergeben.
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        // Iteration durch das textbox-array, jedes Textboxelement bekommt eine Zeile aus der Speicherdatei zugewiesen
                        foreach (TextBox tb in tbArr)
                        {
                            tb.Text = sr.ReadLine();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            #endregion
            #region Farbverwaltung
            // Initialisierung des Brushconverters um mit den Farbcodes zu arbeiten
            var bc = new BrushConverter();

            // Iterieren durch alle Textboxelemente
            foreach (TextBox tb in tbArr)
            {
                // Wenn Textbox nicht leer, dann ist der Hintergrund rötlich
                if (tb.Text != "")
                {
                    tb.Background = (Brush)bc.ConvertFrom("#f76c7f");
                }
                // Wenn Textbox leer, dann ist der Hintergrund grünlich
                else
                {
                    tb.Background = (Brush)bc.ConvertFrom("#90ee8d");
                }
            }
            #endregion
        }
    }
}
