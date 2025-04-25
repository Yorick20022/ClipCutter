using SQLite;
using ClipCutter.models;

namespace ClipCutter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void folderDialogButton_Click(object sender, EventArgs e)
        {
            using SQLiteConnection db = new("./clipcutter.db");
            using FolderBrowserDialog folderDialog = new();
            folderDialog.Description = "Select a folder";
            folderDialog.ShowNewFolderButton = true;

            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                string outputPathValue = folderDialog.SelectedPath;

                var existingConfig = db.Find<Config>(1);

                if (existingConfig != null)
                {
                    existingConfig.OutputPath = outputPathValue;
                    db.Update(existingConfig);
                    MessageBox.Show("Output path updated successfully!");
                }
                else
                {
                    var newConfig = new Config()
                    {
                        Id = 1, // if needed
                        OutputPath = outputPathValue
                    };
                    db.Insert(newConfig);
                    MessageBox.Show("Output path set successfully!");
                }
            }
        }
    }
}
