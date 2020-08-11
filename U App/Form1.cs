using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Upload;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Google.Apis.Drive.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace U_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        static string[] Scopes = { DriveService.Scope.Drive };
        String filepath;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void panel2_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 2);
            pen.DashPattern = new float[] { 2, 2 };
            e.Graphics.DrawRectangle(pen, 1, 1, panel2.Width - 2, panel2.Height - 2);
        }

        private void panel2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void panel2_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttons4);
            panel2.Controls.Add(buttons5);

            label1.Visible = true;
            label1.Location = new Point(189, 64);

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            label1.Text = files[0].ToString();
        }

        void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 2);
            pen.DashPattern = new float[] { 2, 2 };
            e.Graphics.DrawRectangle(pen, 1, 1, panel3.Width - 2, panel3.Height - 2);
        }

        private void panel3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void panel3_DragLeave(object sender, EventArgs e)
        {

        }

        private void panel3_DragDrop(object sender, DragEventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttons8);
            panel3.Controls.Add(buttons9);

            label1.Visible = true;
            label1.Location = new Point(189, 64);

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            label1.Text = files[0].ToString();
        }

        private void buttons1_Click(object sender, EventArgs e)
        {
            buttons1.BackColor = SystemColors.AppWorkspace;
            buttons1.ForeColor = SystemColors.Control;
            buttons2.BackColor = SystemColors.Control;
            buttons2.ForeColor = SystemColors.AppWorkspace;
            panel1.Controls.Clear();
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel2.Controls.Add(buttons3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            label3.Text = "Загрузка видео";
            panel1.Invalidate();
        }

        private void buttons2_Click(object sender, EventArgs e)
        {
            buttons2.BackColor = SystemColors.AppWorkspace;
            buttons2.ForeColor = SystemColors.Control;
            buttons1.BackColor = SystemColors.Control;
            buttons1.ForeColor = SystemColors.AppWorkspace;
            panel1.Controls.Clear();
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            label3.Text = "Загрузка файлов";
            panel1.Invalidate();
        }

        private void buttons3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберете видео файл для загрузки на сервер";
            file.InitialDirectory = @"C:\";
            if (file.ShowDialog() == DialogResult.OK)
            {
                panel2.Controls.Clear();
                panel2.Controls.Add(label1);
                panel2.Controls.Add(buttons4);
                panel2.Controls.Add(buttons5);
                label1.Parent = panel2;
                label1.Visible = true;
                label1.Location = new Point(189, 64);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Text = file.FileName;
                label1.AutoSize = false;
            }
            else
            {
                label1.Text = "Перетащите файлы сюда";
            }
        }

        private void buttons4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(label1);
            panel2.Controls.Add(buttons6);
            panel2.Controls.Add(progressBar1);
            progressBar1.Location = new Point(80, 94);
            buttons6.Location = new Point(225, 130);
            label1.Location = new Point(100, 54);
            label1.Visible = true;
            try
            {
                Thread thead = new Thread(() =>
                {
                    Run().Wait();
                });
                thead.IsBackground = true;
                thead.Start();

            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task Run()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows an application to upload files to the
                    // authenticated user's YouTube channel, but doesn't allow other types of access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None
                );
            }

            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });

            var video = new Video();
            video.Snippet = new VideoSnippet();
            video.Snippet.Title = textBox1.Text;
            video.Snippet.Description = textBox2.Text;
            string[] tagSeo = Regex.Split(textBox2.Text, ",");
            video.Snippet.Tags = tagSeo;
            video.Snippet.CategoryId = "22"; // Подробнее https://developers.google.com/youtube/v3/docs/videoCategories/list
            video.Status = new VideoStatus();
            video.Status.PrivacyStatus = "public"; // или "private" или "public"
            var filePath = label1.Text; // Путь к файлу.

            using (var fileStream = new FileStream(filePath, FileMode.Open))
            {
                var videosInsertRequest = youtubeService.Videos.Insert(video, "snippet,status", fileStream, "video/*");
                videosInsertRequest.ProgressChanged += videosInsertRequest_ProgressChanged;
                videosInsertRequest.ResponseReceived += videosInsertRequest_ResponseReceived;

                await videosInsertRequest.UploadAsync();
            }
        }

        void videosInsertRequest_ProgressChanged(Google.Apis.Upload.IUploadProgress progress)
        {

            switch (progress.Status)
            {
                case UploadStatus.Starting:
                    break;

                case UploadStatus.Uploading:

                    label1.Text = String.Format("{0} мб загружено.", progress.BytesSent / 1048576); ;
                    break;

                case UploadStatus.Completed:
                    DialogResult dialog = MessageBox.Show("Загзузка успешно завершена.", "Чтобы вернуться в начало, нажмите ОК", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dialog == DialogResult.OK)
                    {
                        panel2.Controls.Clear();
                        panel2.Controls.Add(label1);
                        panel2.Controls.Add(label2);
                        panel2.Controls.Add(buttons3);
                    }
                    break;

                case UploadStatus.Failed:
                    label1.Text = String.Format("Обнаружена ошибка не позволяющая завершить загрузку.\n{0}", progress.Exception);
                    break;
            }
        }

        void videosInsertRequest_ResponseReceived(Video video)
        {
            label1.Text = string.Format("Видео: {0} успешно загружено.", video.Id);
        }

        private void buttons5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(buttons3);
            label1.Text = "Перетащите файлы сюда";
        }

        private void buttons6_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Нажав кнопку 'Да', вы прервете загрузку", "Вы уверены что хотите остановить загрузку?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                panel2.Controls.Clear();
                panel2.Controls.Add(label1);
                panel2.Controls.Add(label2);
                panel2.Controls.Add(buttons3);
            }
            label1.Text = "Перетащите файлы сюда";
        }

        private void buttons7_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Выберете видео файл для загрузки на сервер";
            file.InitialDirectory = @"C:\";
            if (file.ShowDialog() == DialogResult.OK)
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(label1);
                panel3.Controls.Add(buttons8);
                panel3.Controls.Add(buttons9);
                label1.Parent = panel2;
                label1.Visible = true;
                label1.Location = new Point(189, 64);
                label1.TextAlign = ContentAlignment.MiddleCenter;
                filepath = file.FileName;
                textBox4.Text = filepath;
                textBox4.AutoSize = false;
            }
            else
            {
                label1.Text = "Перетащите файлы сюда";
            }
        }

        private void buttons8_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(buttons3);
            label1.Text = "Перетащите файлы сюда";
        }

        private void buttons9_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            panel3.Controls.Add(label1);
            panel3.Controls.Add(buttons10);
            panel3.Controls.Add(progressBar1);
            progressBar1.Location = new Point(80, 94);
            buttons10.Location = new Point(225, 130);
            label1.Location = new Point(100, 54);
            label1.Visible = true;
            try
            {
                Thread thead = new Thread(() =>
                {
                    Run1().Wait();
                });
                thead.IsBackground = true;
                thead.Start();

            }
            catch (AggregateException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttons10_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Нажав кнопку 'Да', вы прервете загрузку", "Вы уверены что хотите остановить загрузку?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                panel3.Controls.Clear();
                panel3.Controls.Add(label1);
                panel3.Controls.Add(label2);
                panel3.Controls.Add(buttons7);
            }
            label1.Text = "Перетащите файлы сюда";
            label1.Location = new Point(189, 64);
        }

        private async Task Run1()
        {
            UserCredential credential;
            using (var stream = new FileStream("client_id.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None);
            }

            var GoogleDriveService = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });
            GoogleDriveService.HttpClient.Timeout = TimeSpan.FromMinutes(100);
            var respocne = uploadFile(GoogleDriveService, textBox4.Text, "");
            // Third parameter is empty it means it would upload to root directory, if you want to upload under a folder, pass folder's id here Uncomment Line 94.

            //MessageBox.Show("Process completed--- Response--" + respocne);
        }

        public Google.Apis.Drive.v3.Data.File uploadFile(DriveService _service, string _uploadFile, string _parent, string _descrp = "Uploaded with .NET!")
        {
            if (File.Exists(_uploadFile))
            {
                Google.Apis.Drive.v3.Data.File body = new Google.Apis.Drive.v3.Data.File();
                body.Name = Path.GetFileName(_uploadFile);
                body.Description = _descrp;
                body.MimeType = GetMimeType(_uploadFile);
                // UN-comment the following line if you want to upload to a folder(ID of parent folder need to be send as paramter in above method)
                //body.Parents = new List<string> { _parent };
                byte[] byteArray = System.IO.File.ReadAllBytes(_uploadFile);
                System.IO.MemoryStream stream = new MemoryStream(byteArray);
                try
                {
                    FilesResource.CreateMediaUpload request = _service.Files.Create(body, stream, GetMimeType(_uploadFile));
                    request.SupportsTeamDrives = true;
                    // You can bind event handler with progress changed event and response recieved(completed event)
                    request.ProgressChanged += Request_ProgressChanged;
                    request.ResponseReceived += Request_ResponseReceived;
                    var task = request.UploadAsync();
                    task.ContinueWith(t =>
                    {
                        // Remeber to clean the stream.
                        stream.Dispose();
                    });
                    return request.ResponseBody;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Произошла Ошибка");
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Файл не существует.", "404");
                return null;
            }
        }

        private static string GetMimeType(string fileName) { string mimeType = "application/unknown"; string ext = Path.GetExtension(fileName).ToLower(); Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(ext); if (regKey != null && regKey.GetValue("Content Type") != null) mimeType = regKey.GetValue("Content Type").ToString(); Debug.WriteLine(mimeType); return mimeType; }

        public void Request_ProgressChanged(Google.Apis.Upload.IUploadProgress obj)
        {
            byte[] byteArray1 = System.IO.File.ReadAllBytes(filepath);
            double totalFileSize = BitConverter.ToInt32(byteArray1, 0);

            Task op = new Task((Action)(() =>
            {
                progressBar1.Value += (int)(obj.BytesSent * 100 / totalFileSize);
                if (obj.Status.ToString() == "Starting")
                {
                    progressBar1.Value = 5;
                    MessageBox.Show("Upload Started");
                }
                else if (obj.Status.ToString() == "Completed")
                {
                    progressBar1.Value = 100;
                    MessageBox.Show("Upload Complete");
                }
            }));

            Debug.Write(obj.Status + "\r\r " + obj.BytesSent);
        }

        private void Request_ResponseReceived(Google.Apis.Drive.v3.Data.File obj)
        {
            if (obj != null)
            {
                //MessageBox.Show("File was uploaded sucessfully--" + obj.Id);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enter -= textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Text = "Введите название видео";
            textBox1.Enter += textBox1_Enter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Leave -= textBox1_Leave;
            textBox1.TextChanged -= textBox1_TextChanged;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Enter -= textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Text = "Введите описание видео";
            textBox2.Enter += textBox2_Enter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Leave -= textBox2_Leave;
            textBox2.TextChanged -= textBox2_TextChanged;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Enter -= textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            textBox3.TextChanged += textBox3_TextChanged;
        }

        void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Text = "Введите теги для видео";
            textBox3.Enter += textBox3_Enter;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Leave -= textBox3_Leave;
            textBox3.TextChanged -= textBox3_TextChanged;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Enter -= textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            textBox4.TextChanged += textBox4_TextChanged;
        }

        void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Text = "Введите название файла";
            textBox4.Enter += textBox4_Enter;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Leave -= textBox4_Leave;
            textBox4.TextChanged -= textBox4_TextChanged;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Enter -= textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            textBox5.TextChanged += textBox5_TextChanged;
        }

        void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.DarkGray;
            textBox5.Text = "Введите описание загружаемого файла";
            textBox5.Enter += textBox5_Enter;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Leave -= textBox5_Leave;
            textBox5.TextChanged -= textBox5_TextChanged;
        }
    }
}
