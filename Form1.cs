namespace WinFormsStringMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplitname_Click(object sender, EventArgs e)
        {
            string fullName="", firstname="", lastname="", title="";
            int x = 0;
            //กำจัด space หน้าสุดและหลังสุดออก
            fullName = txtFullname.Text.Trim();

            //ตรวจสอบว่ามีคำว่ามีคำนำหน้าที่ต้องการหรือไม่ "นางสาว", "นาง", "นาย"
            //ตัดคำนำหน้าออกไปแสดงผล
            if (fullName.StartsWith("นางสาว"))
            {
                x = 6;
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("นาง")|| fullName.StartsWith("นาย"))
            {
                x = 3;
                title=fullName.Substring(0, x);
            }
            fullName = fullName.Substring(x).Trim();

            //หาช่องว่างระหว่างชื่อและนามสกุล
            x=fullName.IndexOf(' ');

            //ตัดตั้งแต่ตัวที่ 0 จนถึงตำแหน่งช่องว่างจะได้ชื่อ
            firstname = fullName.Substring(0, x).Trim();

            //ตัดตั้งแต่ตำแหน่งช่องว่าง ไปจนหมดข้อความจะได้นามสกุล
            lastname = fullName.Substring(x).Trim();

            //แสดงผล
            txtTitle.Text = title;
            txtFristName.Text = firstname;
            txtLastName.Text = lastname;

        }
    }
}
