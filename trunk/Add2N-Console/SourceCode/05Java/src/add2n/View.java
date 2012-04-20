/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package add2n;
import java.io.*;
import java.lang.*;
import java.util.Scanner;
/**
 *
 * @author PhongAudio
 */
public class View {
    public static void introduce(){
        System.out.println("Nhap thong tin theo cau truc: Add2N [So1] [So2] \n");
    }

    //Tra ve mang chuoi gom hai so hang nhap vao
    public static String[] inputNumber(){
        String strInput;
        String[] arrInput;
        System.out.print("\nNhap thong tin: ");
        Scanner in = new Scanner(System.in);
        strInput = in.nextLine().trim();
        arrInput = strInput.split(" ");

        return arrInput;
    }

    //Hien Thi Chuoi Truyen Vao
    public static void displayRes(String result)
    {
        System.out.println(result);
        
    }

}
