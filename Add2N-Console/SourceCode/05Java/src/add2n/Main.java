/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package add2n;
import java.util.Scanner;
/**
 *
 * @author PhongAudio
 */
public class Main {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here



            Logic Controller = new Logic();


            View.introduce();

            View.displayRes(Controller.addResult(View.inputNumber()));


        }

       
    

}
