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
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Main
{
    /// <summary>
    /// Interaction logic for Speech.xaml
    /// </summary>
    public partial class Speech : Window
    {
        
        
        public Speech()
        {
            InitializeComponent();
            


        }
        SpeechSynthesizer synth = new SpeechSynthesizer();
        PromptBuilder builder = new PromptBuilder();
        SpeechRecognitionEngine recog = new SpeechRecognitionEngine();


        

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b1.IsEnabled = false;
            Choices list = new Choices();
            list.Add(new string[] {"hello", "test","it works", "sup" });
            Grammar gr = new Grammar(new GrammarBuilder(list));
            try
            {
                recog.RequestRecognizerUpdate();
                recog.LoadGrammar(gr);
                recog.SpeechRecognized += Recog_SpeechRecognized;
                recog.SetInputToDefaultAudioDevice();
                recog.RecognizeAsync(RecognizeMode.Multiple);
            }

            catch
            {
                return;
            }
        }

        private void Recog_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show("Speech Recognised :" + e.Result.Text.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int i = 1;
            Modal x = new Modal(i, cmdText.Text, cmdText.Text);
            x.Save();
        }
    }
}
