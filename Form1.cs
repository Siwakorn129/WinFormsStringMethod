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
            //�ӨѴ space ˹���ش�����ѧ�ش�͡
            fullName = txtFullname.Text.Trim();

            //��Ǩ�ͺ����դ�����դӹ�˹�ҷ���ͧ���������� "�ҧ���", "�ҧ", "���"
            //�Ѵ�ӹ�˹���͡��ʴ���
            if (fullName.StartsWith("�ҧ���"))
            {
                x = 6;
                title = fullName.Substring(0, x);
            }
            else if (fullName.StartsWith("�ҧ")|| fullName.StartsWith("���"))
            {
                x = 3;
                title=fullName.Substring(0, x);
            }
            fullName = fullName.Substring(x).Trim();

            //�Ҫ�ͧ��ҧ�����ҧ������й��ʡ��
            x=fullName.IndexOf(' ');

            //�Ѵ������Ƿ�� 0 ���֧���˹觪�ͧ��ҧ�������
            firstname = fullName.Substring(0, x).Trim();

            //�Ѵ�������˹觪�ͧ��ҧ 仨������ͤ���������ʡ��
            lastname = fullName.Substring(x).Trim();

            //�ʴ���
            txtTitle.Text = title;
            txtFristName.Text = firstname;
            txtLastName.Text = lastname;

        }
    }
}
