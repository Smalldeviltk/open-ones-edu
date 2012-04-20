/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package add2n;
import java.lang.String;
/**
 *
 * @author PhongAudio
 */
public class Logic {
    String[] number; // Bien nho 2 so nhap vao de thuc hien phep tinh
    String result; //Ket qua
    Boolean check = true; // Bien kiem tra cau truc nhap vao dung hay sai
    String warning;    // Chuoi hien thi canh bao


    //Tinh toan va tra ve ket qua cua phep tinh cong
    public String addResult(String[] SoHang)
    {
            // Kiem tra cau truc nhap vao dung hay sai
            checkValid(SoHang);
            // Neu khong co loi thi thuc hien tinh toan
            if (check)
            {
                int du = 0; // Luu so du khi cong
                int tong; // Luu ket qua
                String[] temp = number;

                while (temp[1].length() < temp[2].length()) temp[1] = '0' + temp[1];
                while (temp[2].length() < temp[1].length()) temp[2] = '0' + temp[2];
                for (int i = number[1].length() - 1; i >= 0; i--)
                {
                    tong = temp[1].charAt(i) + temp[2].charAt(i) - 96 + du;
                    result = (char)((tong % 10) + 48) + result;
                    du = tong / 10;
                }
                while (du > 0)
                {
                    result = (char)(du % 10 + 48) + result;
                    du /= 10;
                }
                return "\tKET QUA: " + number[1] + " + " + number[2] + " = " + result;
            }
        
            else
                return "\tTHONG BAO LOI:\t\t" + warning;
    }


    //Kiem tra tinh hop le cua cau truc nhap vao
    public Boolean checkValid(String[] strCheck)
    {
        // Reset lai cac bien du lieu
        number = null;
        result = null;
        check = true;
        warning = null;

        // Lay thong tin so nhap vao
        number = strCheck;

        // Kiem tra cau truc nhap vao dung hay sai
        if (number.length == 3)
        {
            // Kiem tra tu khoa nhap vao. Neu sai thi tra ve check = false va luu canh bao
            if (number[0].toLowerCase().equals("add2n") == false)
            {
                warning += number[0] + " khong hop le";
                check = false;
            }

            // Kiem tra so thu nhat nhap vao> Neu sai thi tra ve check = false va luu canh bao
            for (int i = 0; i < number[1].length(); i++)
            {
                if ((number[1].charAt(i) < 48) || (number[1].charAt(i) > 57))
                {
                    check = false;
                    if (warning == null)
                        warning += "\n" + number[1] + " khong hop le";
                    else if (warning.contains(number[1] + " khong hop le") == false)
                        warning += "\n" + number[1] + " khong hop le";
                }

            }

            // Kiem tra so thu hai nhap vao. Neu sai thi tra ve check = false va luu canh bao
                for (int i = 0; i < number[2].length(); i++)
                {
                    if (number[2].charAt(i) < 48 || number[2].charAt(i) > 57)
                    {
                        check = false;
                        if (warning == null)
                            warning += "\n" + number[2] + " khong hop le";
                        else if (warning.contains(number[2] + " khong hop le") == false)
                            warning += "\n" + number[2] + " khong hop le";
                    }
                }

             }
            else
            {
                warning += "\n" + "Nhap thong tin khong theo cau truc!";
                check = false;
            }

        return check;

       }

    }

