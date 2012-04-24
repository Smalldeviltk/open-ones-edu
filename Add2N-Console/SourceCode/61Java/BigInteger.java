/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package biginteger;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
/**
 *
 * @author hoangdoan
 * @mssv 08520647
 *
 */
public class BigInteger {

    private static int[] NumC;
    private static int[] NumD;
    private static int[] result;
    public BigInteger(){
    NumC = null;
    NumD = null;
    result = null;
}//Assessor
public static void main(String[] args) throws IOException {
    String aa="";
    String bb="";
    int thoat=0;
    String CurLine = "";
    String[] chuoi;
    InputStreamReader converter = new InputStreamReader(System.in);
    BufferedReader in = new BufferedReader(converter);
   do{
       
         System.out.println("Nhập theo mẫu: Add2N num1 num2");
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
        else thoat=1;
             
    }while(thoat!=1);
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
public  BigInteger(int[] a,int[] b,int[] c){
    this.NumC = a;
    this.NumD = b;
    this.result = c;
}//Constructor
public static void setNumC (int[] a){
    NumC = a;
}//Mutator NumC
public static void setNumD (int [] b){
        NumD = b;
}//Mutator NumD
public static void setResult (int[] c){
    result = c;
}//Mutator NumC
public static int[] convertArray(String b){
    int[]arr = new int[b.length()];
    for (int i = 0; i < b.length(); i++){
        arr[i] = Character.digit(b.charAt(i),10);
    }
    return arr;
}//end of toArray
public static void flipArray(int[] b) {
    int left = 0;
    int right = b.length-1;
    while (left < right) {
        int temp = b[left];
        b[left] = b[right];
        b[right] = temp;
        left++;
        right--;
    }
}//FilpArray
public static void Add (int[]a,int[]b){
    int sum = 0;
    flipArray(a); // filps array
    flipArray(b); // 123 becomes 321
    int[] arr1,arr2;
    if(a.length<b.length)
    {
      arr1 = new int[b.length];
      for(int i=0;i<a.length;i++)
           arr1[i]=a[i];
      for(int i=a.length;i<b.length;i++)
           arr1[i]=0;
    arr2=b;
    }
    else
    {
      arr1 = new int[a.length];
      for(int i=0;i<b.length;i++)
         arr1[i]=b[i];
      for(int i=b.length;i<a.length;i++)
          arr1[i]=0;
    arr2=a;
    }
    int[] c = new int[arr1.length];
    int diff = 0;
    for (int i = 0; i<arr1.length; i++){
      sum = arr1[i] + arr2[i]+ diff;
      diff = 0;
      if (sum > 9 && i <=arr1.length-2){
          sum -= 10;
      diff = 1;
         }
      c[i] = sum;
    }
    flipArray(c);
        print(c);
}//Add method
public static int[] getSumC(){
    return NumC;
}//Assessor
public static int[] getSumD(){
    return NumD;
}//Assessor
public static int[] getResult (){
    return result;
}//Assessor
public static void print(int[] b){
    int i = 0;
    for(i = 0;i < b.length;i++){
        System.out.print(b[i]);
        }
    }
@Override
public  String toString(){
    if(NumC == null){
    print(NumC);
    }
    else if(NumD == null){
    print(NumD);
    }
    return ("error");
    }
}
