private void btnTinh_Click(object sender, EventArgs e)
{
    int soDien = int.Parse(txtDien.Text);
    double tien;

    if (soDien <= 50)
        tien = soDien * 1500;
    else
        tien = 50 * 1500 + (soDien - 50) * 2000;

    lblKQ.Text = "Tiền điện: " + tien;
}