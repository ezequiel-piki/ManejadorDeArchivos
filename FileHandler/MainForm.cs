namespace FileHandler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }

        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSytemDrives.Items.Add(drive);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboSytemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSytemDrives.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);

                var driveDetails = $@"
                 Drive               : {disk} 
                 Total size          : {diskInfo.TotalSize}
                 Free Space available: {diskInfo.AvailableFreeSpace}
                 Format              : {diskInfo.DriveFormat}
                 Type                : {diskInfo.DriveType}
                 ";
                txtSystemDetails.Text = driveDetails.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                {
                    throw new Exception("Please, enter a path for the directory.");
                }

                if (!Directory.Exists(txtNewDirectory.Text))
                {

                    Directory.CreateDirectory(txtNewDirectory.Text);

                    MessageBox.Show("Directory Created");
                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make sure you have included a directory path on New Directory");

                if (string.IsNullOrEmpty(txtSubDirectory.Text))
                    throw new Exception("Make sure you have included a path of the New Sub-Directory");

                if (!Directory.Exists(txtNewDirectory.Text))
                { throw new Exception("El directorio no existe."); }

                var directoryPath = txtNewDirectory.Text;

                var subDirectoryInfo = new DirectoryInfo(directoryPath);

                subDirectoryInfo.CreateSubdirectory(txtSubDirectory.Text);
                MessageBox.Show("Subdirectory has been created");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListFiles_Click(object sender, EventArgs e)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(txtNewDirectory.Text);
                var subDirectories = directoryInfo.GetDirectories();


                var files = directoryInfo.GetFiles("*");


                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                {
                    throw new Exception("Para ver el listado de archivos debe ingregar el path del directorio y crearlo.");
                }

                if (Directory.Exists(txtNewDirectory.Text))
                {
                    foreach (var d in subDirectories)
                    {
                        cboListFiles.Items.Add(d.Name);
                    }

                    foreach (var item in files)
                    {
                        cboListFiles.Items.Add(item.Name);
                    }

                }
                else
                {
                    MessageBox.Show("Please, enter the full path of the new directory");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cboListFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var directory = cboListFiles.SelectedItem.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDestination.Text) || string.IsNullOrEmpty(txtSource.Text))
                {
                    throw new Exception("Los campos source y destination no pueden estar vacios");
                }

                var sourceDirectory = new DirectoryInfo(txtSource.Text);
                var destinationDirectory = new DirectoryInfo(txtDestination.Text);

                CopyDirectory(sourceDirectory, destinationDirectory);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void CopyDirectory(DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory)
        {
            try
            {
                if (!sourceDirectory.Exists)
                    throw new Exception("Source Directory doesn't exists");


                if (!destinationDirectory.Exists)
                    destinationDirectory.Create();


                var files = sourceDirectory.GetFiles();

                foreach (var file in files)
                {
                    file.CopyTo(Path.Combine(destinationDirectory.FullName, file.Name));

                }

                var directories = sourceDirectory.GetDirectories();

                foreach (var directory in directories)
                {
                    string destination = Path.Combine(destinationDirectory.FullName, directory.Name);
                    CopyDirectory(directory, new DirectoryInfo(destination));
                }

                MessageBox.Show("Directory copied successfully.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {

        }
    }
}