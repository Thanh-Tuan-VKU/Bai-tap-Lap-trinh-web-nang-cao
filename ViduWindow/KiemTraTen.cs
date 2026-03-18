private void btnCheck_Click(object sender, EventArgs e)
{
    string ten = txtTen.Text;
    bool hopLe = true;

    for (int i = 0; i < ten.Length; i++)
    {
        if (char.IsDigit(ten[i]))
        {
            hopLe = false;
            break;
        }
    }

    if (hopLe)
        lblThongBao.Text = "Tên hợp lệ";
    else
        lblThongBao.Text = "Tên không hợp lệ";
}