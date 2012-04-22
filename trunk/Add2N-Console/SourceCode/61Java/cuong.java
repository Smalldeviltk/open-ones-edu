package biginteger;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
public static void main(String[] args) throws IOException {
    String aa="";
    String bb="";
    int thoat=0;
    String CurLine = "";
    String[] chuoi;
    InputStreamReader converter = new InputStreamReader(System.in);
    BufferedReader in = new BufferedReader(converter);
   do{
       
         System.out.println("Nh?p theo m?u: Add2N num1 num2");
         CurLine = in.readLine(); 
         chuoi= CurLine.split(" ");
         Pattern pattern = Pattern.compile("\\d*"); 
         aa=chuoi[1];
         Matcher matcher = pattern.matcher(aa); 
         bb=chuoi[2]; 
         Matcher matcher2 = pattern.matcher(bb); 
         if (!matcher.matches())  
              System.out.println(aa+" - Not a Number"); 
        else if (!matcher2.matches())            
              System.out.println(bb+" - Not a Number");
        else thoat=1;						|
             							| Cuong
    }while(thoat!=1);						|
    NumC = convertArray(aa);
    setNumC(NumC);
    NumD = convertArray(bb);
    setNumD(NumD);
    System.out.println();
    System.out.print(" ");
    print(NumC);
    System.out.print(" + ");
    print(NumD);
    System.out.print(" = ");
    Add(NumC,NumD);
}// Input
_______________