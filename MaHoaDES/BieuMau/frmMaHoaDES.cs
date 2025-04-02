using AOC.ThuVien;
using MaHoaDES.DoiTuong;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MaHoaDES.BieuMau
{
    public partial class frmMaHoaDES : Form
    {
        public frmMaHoaDES()
        {
            InitializeComponent();
        }
        private void EnableHoacDisableNut(bool b)
        {
            btnChonFile.Enabled = btnGiaiMaFile.Enabled = btnGiaiMaVanBan.Enabled = btnMaHoaFile.Enabled = btnMaHoaVanBan.Enabled = b;
        }
        int MaHoaHayGiaiMa = 1;
        bool FileHayChuoi = false;
        DES64Bit MaHoaDES64;
        Khoa Khoa;
        Thread thread;
        private void Chay()
        {
            ThreadStart start = new ThreadStart(MaHoa);
            thread = new Thread(start);
            thread.Start();
        }

        private void MaHoa()
        {
            try
            {
                MaHoaDES64 = new DES64Bit();
                TenTienTrinh = "";
                GiaiDoan = 0;
                Dem = 0;

                var stopwatch = new System.Diagnostics.Stopwatch(); // Đối tượng để đo thời gian
                stopwatch.Start();

                if (FileHayChuoi)
                {
                    string key = GetTextFromTextBox(txtKhoaFile);
                    if (key.Length != 16)
                    {
                        UpdateProgress("", 0);
                        MessageBox.Show("Error: Khóa có độ dài không hợp lệ", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetPictureBoxVisibility(false);
                        return;
                    }
                    Khoa = new Khoa(txtKhoaFile.Text);

                    if (MaHoaHayGiaiMa == 1)
                    {
                        SetPictureBoxVisibility(true);
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(txtFileNguon.Text, UpdateProgress);

                        if (chuoi == null)
                        {
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        if (chuoi.DoDai == 0)
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: File không có nội dung", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }

                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, 1, UpdateProgress);
                        UpdateProgress("Ghi kết quả ra file đích", 900);
                        DocFileTxt.WriteBinaryToFile(txtFileDich.Text, KQ, UpdateProgress);

                        stopwatch.Stop();
                        UpdateProgress("", 1000);
                        SetPictureBoxVisibility(false);
                        TimeSpan time = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds);
                        MessageBox.Show($"Mã hóa file thành công! Thời gian thực hiện: {time.ToString(@"hh\:mm\:ss\:fff")}");
                    }
                    else
                    {
                        SetPictureBoxVisibility(true);
                        ChuoiNhiPhan chuoi = DocFileTxt.FileReadToBinary(txtFileNguon.Text, UpdateProgress);
                        if (chuoi == null)
                        {
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        if (chuoi.DoDai == 0)
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: File không có nội dung", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        if (chuoi.DoDai % 64 != 0)
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: Dữ liệu đầu vào có độ dài không hợp lệ", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        ChuoiNhiPhan KQ = MaHoaDES64.ThucHienDES(Khoa, chuoi, -1, UpdateProgress);
                        if (KQ == null)
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Lỗi giải mã. Kiểm tra khóa");
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        UpdateProgress("Ghi kết quả ra file đích", 900);
                        DocFileTxt.WriteBinaryToFile(txtFileDich.Text, KQ, UpdateProgress);

                        stopwatch.Stop();
                        UpdateProgress("", 1000);
                        SetPictureBoxVisibility(false);
                        TimeSpan time = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds);
                        MessageBox.Show($"Giải mã file thành công! Thời gian thực hiện: {time.ToString(@"hh\:mm\:ss\:fff")}");
                    }
                }
                else
                {
                    string key = GetTextFromTextBox(txtKhoaVanBan);
                    if (key.Length != 16)
                    {
                        UpdateProgress("", 0);
                        MessageBox.Show("Error: Khóa có độ dài không hợp lệ", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        SetPictureBoxVisibility(false);
                        return;
                    }

                    Khoa = new Khoa(txtKhoaVanBan.Text);


                    if (MaHoaHayGiaiMa == 1)
                    {
                        string plainText = GetTextFromTextBox(txtVanBanNguon);
                        if (plainText == "")
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: Không có dữ liệu để mã hóa", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        SetPictureBoxVisibility(true);
                        MaHoaDES64 = new DES64Bit();
                        string kq = MaHoaDES64.ThucHienDESText(Khoa, GetTextFromTextBox(txtVanBanNguon), 1, UpdateProgress);
                        SetTextToTextBox(txtVanBanDich, kq);

                        stopwatch.Stop();
                        UpdateProgress("", 1000);
                        SetPictureBoxVisibility(false);
                        TimeSpan time = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds);
                        MessageBox.Show($"Mã hóa chuỗi thành công! Thời gian thực hiện: {time.ToString(@"hh\:mm\:ss\:fff")}");
                    }
                    else
                    {
                        string plainText = GetTextFromTextBox(txtVanBanNguon);
                        if (plainText == "")
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: Không có dữ liệu để giải mã", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }


                        MaHoaDES64 = new DES64Bit();
                        SetPictureBoxVisibility(true);

                        string kq = MaHoaDES64.ThucHienDESText(Khoa, GetTextFromTextBox(txtVanBanNguon), -1, UpdateProgress);
                        if (kq == null)
                        {
                            UpdateProgress("", 0);
                            MessageBox.Show("Error: Dữ liệu đầu vào có độ dài không hợp lệ", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            SetPictureBoxVisibility(false);
                            return;
                        }
                        SetTextToTextBox(txtVanBanDich, kq);
                        if (kq == "") return;

                        stopwatch.Stop();
                        UpdateProgress("", 1000);
                        SetPictureBoxVisibility(false);
                        TimeSpan time = TimeSpan.FromMilliseconds(stopwatch.ElapsedMilliseconds);
                        MessageBox.Show($"Giải mã chuỗi thành công! Thời gian thực hiện: {time.ToString(@"hh\:mm\:ss\:fff")}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }

        private void txtMaHoaVanBan_Click(object sender, EventArgs e)
        {
            FileHayChuoi = false;
            MaHoaHayGiaiMa = 1;
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }

        private void txtGiaiMaVanBan_Click(object sender, EventArgs e)
        {

            FileHayChuoi = false;
            MaHoaHayGiaiMa = -1;
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }

        private void btnMaHoaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = 1;
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }

        private void btnGiaiMaFile_Click(object sender, EventArgs e)
        {
            FileHayChuoi = true;
            MaHoaHayGiaiMa = -1;
            EnableHoacDisableNut(false);
            Chay();
            EnableHoacDisableNut(true);
        }
        private void btnChonFile_Click(object sender, EventArgs e)
        {
            txtFileNguon.Clear();
            txtFileDich.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                UpdateProgress("", 0);
                txtFileNguon.Text = openFileDialog1.FileName;
                txtFileDich.Text = openFileDialog1.FileName.Replace(".", "_2.");
            }
        }
        public static string TenTienTrinh = "";
        public static int GiaiDoan = -1;
        private static int Dem = 0;


        private void frmMaHoaDES_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thread != null && thread.ThreadState == ThreadState.Running)
                thread.Abort();
            //e.Cancel = DangChay;
        }

        private void txtKhoaFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !(ChuoiHexa.BoHexa.Contains(e.KeyChar)))
            {
                e.Handled = true;
            }
        }


        // Callback delegate
        public delegate void ProgressUpdateCallback(string message, int progress);

        public void UpdateProgress(string message, int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action(() =>
                {
                    lblStatus.Text = message; // Luôn cập nhật label

                    if (value != -1) // Chỉ cập nhật progressBar nếu value khác -1
                    {
                        progressBar1.Value = value;
                    }
                }));
            }
            else
            {
                lblStatus.Text = message; // Luôn cập nhật label

                if (value != -1) // Chỉ cập nhật progressBar nếu value khác -1
                {
                    progressBar1.Value = value;
                }
            }
        }
        private void SetTextToTextBox(RichTextBox textBox, string text)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() => textBox.Text = text));
            }
            else
            {
                textBox.Text = text;
            }
        }

        private string GetTextFromTextBox(RichTextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                return (string)textBox.Invoke(new Func<string>(() => textBox.Text));
            }
            else
            {
                return textBox.Text;
            }
        }
        private string GetTextFromTextBox(TextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                return (string)textBox.Invoke(new Func<string>(() => textBox.Text));
            }
            else
            {
                return textBox.Text;
            }
        }
        private void SetPictureBoxVisibility(bool isVisible)
        {
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new Action(() => pictureBox1.Visible = isVisible));
            }
            else
            {
                pictureBox1.Visible = isVisible;
            }
        }


    }
}
