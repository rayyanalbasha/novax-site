using System.Windows;

namespace MyExecutor
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ScriptBox.Text))
            {
                MessageBox.Show("Please write something first!");
            }
            else
            {
                // هنا سيتم تنفيذ السكربت مستقبلاً
                MessageBox.Show("Executing your code...");
            }
        }

        private void Attach_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Attached to process!");
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            ScriptBox.Clear();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}