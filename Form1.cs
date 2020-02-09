using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication4
{
   
       public class Form1 {
    
    public string tobin8(long a) {
        string b = "";
        for (int i = 1;i <= 8; i++) {
            b = ((a % 2)+ b);
            a = a/2;
           
        }
        
        return b;
    }
    
    public string tobin4(long a) {
        string b = "";
        for (int i = 1; i <= 4; i++) {
            b = ((a % 2) + b);
            a = a/2;
           
        }
        
        return b;
    }
    
    public string Xor128(string a, string b) {
        string x = "";
        for (int i = 1; i <= 128; i++) {
           x = (x + double.Parse(a.Substring((i - 1), 1)));
            double.Parse(b.Substring((i - 1), 1)).ToString();
         
        }
        
        return x;
    }
    
    public static long aes (string a) {
        long x=0L;
        int z=0;
    
          

        for (int i=a.Length-1;i>0;i--,z++)
        {
            x = int.Parse(a.Substring((i,1))*(2^z)+x; 
                       
         
    
        }
        
        return x;
    }
    
    public void shift(void s, void b, void m) {
        object l = s.Length;
        if ((m == "l")) {
            for (j = 0; (j 
                        <= (b - 1)); j++) {
                object t = s.Substring(0, 1);
                for (i = 1; (i 
                            <= (l - 1)); i++) {
                    s.Substring((i - 1), 1) = s.Substring(i, 1);
                }
                
                s.Substring((l - 1), 1) = t;
            }
            
        }
        else if ((m == "r")) {
            for (int j = 0; (j 
                        <= (b - 1)); j++) {
                object t = s.Substring((l - 1), 1);
                for (i = l; (i <= 2); i = (i + -1)) {
                    s.Substring((i - 1), 1) = s.Substring(i, 1);
                }
                
                s.Substring(0, 1) = t;
            }
            
        }
        
        return s;
    }
    
    public string binaryhex(string hexnumber) {
        string BinaryNumber = "";
        int Number = int.Parse(("&H" + hexnumber));
        for (i = 1; (i <= 8); i++) {
            BinaryNumber = ((Number % 2).ToString + BinaryNumber);
            Number = Number/2;
          
        }
        
        return BinaryNumber;
    }
    
    public string xorhex(string a, string b, string c, string d) {
        string x = "";
        for (int i = 1; (i <= 8); i++) {
            x = (x + double.Parse(a.Substring((i - 1), 1)));
            double.Parse(b.Substring((i - 1), 1));
            double.Parse(c.Substring((i - 1), 1));
            double.Parse(d.Substring((i - 1), 1));
           Convert.ToString(x);
        }
        
        return x;
    }
    
    public void mixcolumns(string ab)
{
        string[,] ee;
        "01";
        "03";
        "05";
        "0F";
        "11";
        "33";
        "55";
        "FF";
        "1A";
        "2E";
        "72";
        "96";
        "A1";
        "F8";
        "13";
        "35";
        "5F";
        "E1";
        "38";
        "48";
        "D8";
        "73";
        "95";
        "A4";
        "f7";
        "02";
        "06";
        "0A";
        "1E";
        "22";
        "66";
        "AA";
        "E5";
        "34";
        "5C";
        "E4";
        "37";
        "59";
        "EB";
        "26";
        "6A";
        "BE";
        "D9";
        "70";
        "90";
        "AB";
        "E6";
        "31";
        "53";
        "F5";
        "04";
        "0C";
        "14";
        "3C";
        "44";
        "CC";
        "4F";
        "D1";
        "68";
        "B8";
        "D3";
        "6E";
        "B2";
        "CD";
        "4C";
        "D4";
        "67";
        "A9";
        "E0";
        "3B";
        "4D";
        "D7";
        "62";
        "A6";
        "F1";
        "08";
        "18";
        "28";
        "78";
        "88";
        "83";
        "9E";
        "B9";
        "D0";
        "6B";
        "BD";
        "DC";
        "7F";
        "81";
        "98";
        "B3";
        "CE";
        "49";
        "DB";
        "76";
        "9A";
        "B5";
        "C4";
        "57";
        "F9";
        "10";
        "30";
        "50";
        "F0";
        "0B";
        "1D";
        "27";
        "69";
        "BB";
        "D6";
        "61";
        "A3";
        "FE";
        "19";
        "2B";
        "7D";
        "87";
        "92";
        "AD";
        "EC";
        "2F";
        "71";
        "93";
        "AE";
        "E9";
        "20";
        "60";
        "A0";
        "FB";
        "16";
        "3A";
        "4E";
        "D2";
        "6D";
        "B7";
        "C2";
        "5D";
        "E7";
        "32";
        "56";
        "FA";
        "15";
        "3F";
        "41";
        "C3";
        "5E";
        "E2";
        "3D";
        "47";
        "C9";
        "40";
        "C0";
        "5B";
        "ED";
        "2C";
        "74";
        "9C";
        "BF";
        "DA";
        "75";
        "9F";
        "BA";
        "D5";
        "64";
        "AC";
        "EF";
        "2A";
        "7E";
        "82";
        "9D";
        "BC";
        "DF";
        "7A";
        "8E";
        "89";
        "80";
        "9B";
        "B6";
        "C1";
        "58";
        "E8";
        "23";
        "65";
        "AF";
        "EA";
        "25";
        "6F";
        "B1";
        "C8";
        "43";
        "C5";
        "54";
        "FC";
        "1F";
        "21";
        "63";
        "A5";
        "F4";
        "07";
        "09";
        "1B";
        "2D";
        "77";
        "99";
        "B0";
        "CB";
        "46";
        "CA";
        "45";
        "CF";
        "4A";
        "DE";
        "79";
        "8B";
        "86";
        "91";
        "A8";
        "E3";
        "3E";
        "42";
        "C6";
        "51";
        "F3";
        "0E";
        "12";
        "36";
        "5A";
        "EE";
        "29";
        "7B";
        "8D";
        "8C";
        "8F";
        "8A";
        "85";
        "94";
        "A7";
        "F2";
        "0D";
        "17";
        "39";
        "4B";
        "DD";
        "7C";
        "84";
        "97";
        "A2";
        "FD";
        "1C";
        "24";
        "6C";
        "B4";
        "C7";
        "52";
        "F6";
        "01";
        string[,] l;
        "";
        "00";
        "19";
        "01";
        "32";
        "02";
        "1A";
        "C6";
        "4B";
        "C7";
        "1B";
        "68";
        "33";
        "EE";
        "DF";
        "03";
        "64";
        "04";
        "E0";
        "0E";
        "34";
        "8D";
        "81";
        "EF";
        "4C";
        "71";
        "08";
        "C8";
        "F8";
        "69";
        "1C";
        "C1";
        "7D";
        "C2";
        "1D";
        "B5";
        "F9";
        "B9";
        "27";
        "6A";
        "4D";
        "E4";
        "A6";
        "72";
        "9A";
        "C9";
        "09";
        "78";
        "65";
        "2F";
        "8A";
        "05";
        "21";
        "0F";
        "E1";
        "24";
        "12";
        "F0";
        "82";
        "45";
        "35";
        "93";
        "DA";
        "8E";
        "96";
        "8F";
        "DB";
        "BD";
        "36";
        "D0";
        "CE";
        "94";
        "13";
        "5C";
        "D2";
        "F1";
        "40";
        "46";
        "83";
        "38";
        "66";
        "DD";
        "FD";
        "30";
        "BF";
        "06";
        "8B";
        "62";
        "B3";
        "25";
        "E2";
        "98";
        "22";
        "88";
        "91";
        "10";
        "7E";
        "6E";
        "48";
        "C3";
        "A3";
        "B6";
        "1E";
        "42";
        "3A";
        "6B";
        "28";
        "54";
        "FA";
        "85";
        "3D";
        "BA";
        "2B";
        "79";
        "0A";
        "15";
        "9B";
        "9F";
        "5E";
        "CA";
        "4E";
        "D4";
        "AC";
        "E5";
        "F3";
        "73";
        "A7";
        "57";
        "AF";
        "58";
        "A8";
        "50";
        "F4";
        "EA";
        "D6";
        "74";
        "4F";
        "AE";
        "E9";
        "D5";
        "E7";
        "E6";
        "AD";
        "E8";
        "2C";
        "D7";
        "75";
        "7A";
        "EB";
        "16";
        "0B";
        "F5";
        "59";
        "CB";
        "5F";
        "B0";
        "9C";
        "A9";
        "51";
        "A0";
        "7F";
        "0C";
        "F6";
        "6F";
        "17";
        "C4";
        "49";
        "EC";
        "D8";
        "43";
        "1F";
        "2D";
        "A4";
        "76";
        "7B";
        "B7";
        "CC";
        "BB";
        "3E";
        "5A";
        "FB";
        "60";
        "B1";
        "86";
        "3B";
        "52";
        "A1";
        "6C";
        "AA";
        "55";
        "29";
        "9D";
        "97";
        "B2";
        "87";
        "90";
        "61";
        "BE";
        "DC";
        "FC";
        "BC";
        "95";
        "CF";
        "CD";
        "37";
        "3F";
        "5B";
        "D1";
        "53";
        "39";
        "84";
        "3C";
        "41";
        "A2";
        "6D";
        "47";
        "14";
        "2A";
        "9E";
        "5D";
        "56";
        "F2";
        "D3";
        "AB";
        "44";
        "11";
        "92";
        "D9";
        "23";
        "20";
        "2E";
        "89";
        "B4";
        "7C";
        "B8";
        "26";
        "77";
        "99";
        "E3";
        "A5";
        "67";
        "4A";
        "ED";
        "DE";
        "C5";
        "31";
        "FE";
        "18";
        "0D";
        "63";
        "8C";
        "80";
        "C0";
        "F7";
        "70";
        "07";
        string[,] a;
        "02";
        "03";
        "01";
        "01";
        "01";
        "02";
        "03";
        "01";
        "01";
        "01";
        "02";
        "03";
        "03";
        "01";
        "01";
        "02";
        string x;
        string n;
        string r;
        string v;
        string d;
        d = "";
        int m;
        int m1;
        int f;
        int f1;
        int k;
        int kk;
        int j;
        int jj;
        int mn;
        j = 0;
        jj = 0;
        string c;
        string w;
        string hex1;
        string hex2;
        string p;
        string u;
        string u1;
        string y;
        string t;
        string q;
        y = "";
        t = "";
        for (mn = 0; (mn <= 3); mn++) {
            for (i = 1; (i <= ab.Length); i = (i + 8)) {
                c = ab.Substring((i - 1), 8);
                if ((c == "00000000")) {
                    t = (t + c);
                    goto 1;
                }

               int m = this.int(c.Substring(0, 4));
               int m1 = this.int(c.Substring(4, 4));
                hex1 = (m, m1);
                w = a(jj, j);
                if ((w == "01")) {
                    t = (t + c);
                    goto 1;
                }
                
                f = w.Substring(0, 1);
                f1 = w.Substring(1, 1);
                hex2 = (f, f1);
                int int1 = Convert.ToInt32(hex1, 16);
                int int2 = Convert.ToInt32(hex2, 16);
                int result = ((int1 + int2) 
                            % 255);
                string hexResult = Convert.ToString(result, 16);
                q = hexResult.Length;
                if ((q == 1)) {
                    hexResult = ("0" + hexResult);
                }
                
                u = hexResult.Substring(0, 1);
                u1 = hexResult.Substring(1, 1);
                if ((u == "a")) {
                    kk = "10";
                }
                else if ((u == "b")) {
                    kk = "11";
                }
                else if ((u == "c")) {
                    kk = "12";
                }
                else if ((u == "d")) {
                    kk = "13";
                }
                else if ((u == "e")) {
                    kk = "14";
                }
                else if ((u == "f")) {
                    kk = "15";
                }
                else {
                    kk = u;
                }
                
                if ((u1 == "a")) {
                    k = "10";
                }
                else if ((u1 == "b")) {
                    k = "11";
                }
                else if ((u1 == "c")) {
                    k = "12";
                }
                else if ((u1 == "d")) {
                    k = "13";
                }
                else if ((u1 == "e")) {
                    k = "14";
                }
                else if ((u1 == "f")) {
                    k = "15";
                }
                else {
                    k = double.Parse(u1);
                }
                
                p = ee(double.Parse(kk), double.Parse(k));
                y = this.binaryhex(p);
                t = (t + y);
                1;
                j = (j + 1);
            }
            
            x = t.Substring(0, 8);
            n = t.Substring(8, 8);
            r = t.Substring(16, 8);
            v = t.Substring(24, 8);
            d = (d + this.xorhex(x, n, r, v));
            jj = (jj + 1);
            j = 0;
            t = "";
}
        
        return d;
}



    
    public void mixcolumnsinverse(string s) {
        string[,] ee;
        "01";
        "03";
        "05";
        "0F";
        "11";
        "33";
        "55";
        "FF";
        "1A";
        "2E";
        "72";
        "96";
        "A1";
        "F8";
        "13";
        "35";
        "5F";
        "E1";
        "38";
        "48";
        "D8";
        "73";
        "95";
        "A4";
        "f7";
        "02";
        "06";
        "0A";
        "1E";
        "22";
        "66";
        "AA";
        "E5";
        "34";
        "5C";
        "E4";
        "37";
        "59";
        "EB";
        "26";
        "6A";
        "BE";
        "D9";
        "70";
        "90";
        "AB";
        "E6";
        "31";
        "53";
        "F5";
        "04";
        "0C";
        "14";
        "3C";
        "44";
        "CC";
        "4F";
        "D1";
        "68";
        "B8";
        "D3";
        "6E";
        "B2";
        "CD";
        "4C";
        "D4";
        "67";
        "A9";
        "E0";
        "3B";
        "4D";
        "D7";
        "62";
        "A6";
        "F1";
        "08";
        "18";
        "28";
        "78";
        "88";
        "83";
        "9E";
        "B9";
        "D0";
        "6B";
        "BD";
        "DC";
        "7F";
        "81";
        "98";
        "B3";
        "CE";
        "49";
        "DB";
        "76";
        "9A";
        "B5";
        "C4";
        "57";
        "F9";
        "10";
        "30";
        "50";
        "F0";
        "0B";
        "1D";
        "27";
        "69";
        "BB";
        "D6";
        "61";
        "A3";
        "FE";
        "19";
        "2B";
        "7D";
        "87";
        "92";
        "AD";
        "EC";
        "2F";
        "71";
        "93";
        "AE";
        "E9";
        "20";
        "60";
        "A0";
        "FB";
        "16";
        "3A";
        "4E";
        "D2";
        "6D";
        "B7";
        "C2";
        "5D";
        "E7";
        "32";
        "56";
        "FA";
        "15";
        "3F";
        "41";
        "C3";
        "5E";
        "E2";
        "3D";
        "47";
        "C9";
        "40";
        "C0";
        "5B";
        "ED";
        "2C";
        "74";
        "9C";
        "BF";
        "DA";
        "75";
        "9F";
        "BA";
        "D5";
        "64";
        "AC";
        "EF";
        "2A";
        "7E";
        "82";
        "9D";
        "BC";
        "DF";
        "7A";
        "8E";
        "89";
        "80";
        "9B";
        "B6";
        "C1";
        "58";
        "E8";
        "23";
        "65";
        "AF";
        "EA";
        "25";
        "6F";
        "B1";
        "C8";
        "43";
        "C5";
        "54";
        "FC";
        "1F";
        "21";
        "63";
        "A5";
        "F4";
        "07";
        "09";
        "1B";
        "2D";
        "77";
        "99";
        "B0";
        "CB";
        "46";
        "CA";
        "45";
        "CF";
        "4A";
        "DE";
        "79";
        "8B";
        "86";
        "91";
        "A8";
        "E3";
        "3E";
        "42";
        "C6";
        "51";
        "F3";
        "0E";
        "12";
        "36";
        "5A";
        "EE";
        "29";
        "7B";
        "8D";
        "8C";
        "8F";
        "8A";
        "85";
        "94";
        "A7";
        "F2";
        "0D";
        "17";
        "39";
        "4B";
        "DD";
        "7C";
        "84";
        "97";
        "A2";
        "FD";
        "1C";
        "24";
        "6C";
        "B4";
        "C7";
        "52";
        "F6";
        "01";
        string[,] l;
        "";
        "00";
        "19";
        "01";
        "32";
        "02";
        "1A";
        "C6";
        "4B";
        "C7";
        "1B";
        "68";
        "33";
        "EE";
        "DF";
        "03";
        "64";
        "04";
        "E0";
        "0E";
        "34";
        "8D";
        "81";
        "EF";
        "4C";
        "71";
        "08";
        "C8";
        "F8";
        "69";
        "1C";
        "C1";
        "7D";
        "C2";
        "1D";
        "B5";
        "F9";
        "B9";
        "27";
        "6A";
        "4D";
        "E4";
        "A6";
        "72";
        "9A";
        "C9";
        "09";
        "78";
        "65";
        "2F";
        "8A";
        "05";
        "21";
        "0F";
        "E1";
        "24";
        "12";
        "F0";
        "82";
        "45";
        "35";
        "93";
        "DA";
        "8E";
        "96";
        "8F";
        "DB";
        "BD";
        "36";
        "D0";
        "CE";
        "94";
        "13";
        "5C";
        "D2";
        "F1";
        "40";
        "46";
        "83";
        "38";
        "66";
        "DD";
        "FD";
        "30";
        "BF";
        "06";
        "8B";
        "62";
        "B3";
        "25";
        "E2";
        "98";
        "22";
        "88";
        "91";
        "10";
        "7E";
        "6E";
        "48";
        "C3";
        "A3";
        "B6";
        "1E";
        "42";
        "3A";
        "6B";
        "28";
        "54";
        "FA";
        "85";
        "3D";
        "BA";
        "2B";
        "79";
        "0A";
        "15";
        "9B";
        "9F";
        "5E";
        "CA";
        "4E";
        "D4";
        "AC";
        "E5";
        "F3";
        "73";
        "A7";
        "57";
        "AF";
        "58";
        "A8";
        "50";
        "F4";
        "EA";
        "D6";
        "74";
        "4F";
        "AE";
        "E9";
        "D5";
        "E7";
        "E6";
        "AD";
        "E8";
        "2C";
        "D7";
        "75";
        "7A";
        "EB";
        "16";
        "0B";
        "F5";
        "59";
        "CB";
        "5F";
        "B0";
        "9C";
        "A9";
        "51";
        "A0";
        "7F";
        "0C";
        "F6";
        "6F";
        "17";
        "C4";
        "49";
        "EC";
        "D8";
        "43";
        "1F";
        "2D";
        "A4";
        "76";
        "7B";
        "B7";
        "CC";
        "BB";
        "3E";
        "5A";
        "FB";
        "60";
        "B1";
        "86";
        "3B";
        "52";
        "A1";
        "6C";
        "AA";
        "55";
        "29";
        "9D";
        "97";
        "B2";
        "87";
        "90";
        "61";
        "BE";
        "DC";
        "FC";
        "BC";
        "95";
        "CF";
        "CD";
        "37";
        "3F";
        "5B";
        "D1";
        "53";
        "39";
        "84";
        "3C";
        "41";
        "A2";
        "6D";
        "47";
        "14";
        "2A";
        "9E";
        "5D";
        "56";
        "F2";
        "D3";
        "AB";
        "44";
        "11";
        "92";
        "D9";
        "23";
        "20";
        "2E";
        "89";
        "B4";
        "7C";
        "B8";
        "26";
        "77";
        "99";
        "E3";
        "A5";
        "67";
        "4A";
        "ED";
        "DE";
        "C5";
        "31";
        "FE";
        "18";
        "0D";
        "63";
        "8C";
        "80";
        "C0";
        "F7";
        "70";
        "07";
        string[,] a1;
        "0e";
        "0b";
        "0d";
        "09";
        "09";
        "0e";
        "0b";
        "0d";
        "0d";
        "09";
        "0e";
        "0b";
        "0b";
        "0d";
        "09";
        "0e";
        string x;
        string n;
        string r;
        string v;
        string d;
        string c;
        string w;
        string hex1;
        string hex2;
        string p;
        string u;
        string u1;
        string y;
        string t;
        string f;
        string f1;
        string z;
        string z1;
        string q;
        d = "";
        y = "";
        t = "";
        int m;
        int m1;
        int k;
        int kk;
        int j;
        int jj;
        int mn;
        j = 0;
        jj = 0;
        for (mn = 0; (mn <= 3); mn++) {
            for (i = 1; (i <= s.Length); i = (i + 8)) {
                c = s.Substring((i - 1), 8);
                if ((c == "00000000")) {
                    y = c;
                    goto 2;
                }
                
                m = this.int(c.Substring(0, 4));
                m1 = this.int(c.Substring(4, 4));
                hex1 = l[m, m1];
                w = a1[jj, j];
                f = w.Substring(0, 1);
                f1 = w.Substring(1, 1);
                if ((f == "a")) {
                    z = "10";
                }
                else if ((f == "b")) {
                    z = "11";
                }
                else if ((f == "c")) {
                    z = "12";
                }
                else if ((f == "d")) {
                    z = "13";
                }
                else if ((f == "e")) {
                    z = "14";
                }
                else if ((f == "f")) {
                    z = "15";
                }
                else {
                    z = f;
                }
                
                if ((f1 == "a")) {
                    z1 = "10";
                }
                else if ((f1 == "b")) {
                    z1 = "11";
                }
                else if ((f1 == "c")) {
                    z1 = "12";
                }
                else if ((f1 == "d")) {
                    z1 = "13";
                }
                else if ((f1 == "e")) {
                    z1 = "14";
                }
                else if ((f1 == f)) {
                    z1 = "15";
                }
                else {
                    z1 = f1;
                }
                
                hex2 = l[z, z1];
                int int1 = Convert.ToInt32(hex1, 16);
                int int2 = Convert.ToInt32(hex2, 16);
                int result = ((int1 + int2) 
                            % 255);
                string hexResult = Convert.ToString(result, 16);
                q = hexResult.Length;
                if ((q == 1)) {
                    hexResult = ("0" + hexResult);
                }
                
                u = hexResult.Substring(0, 1);
                u1 = hexResult.Substring(1, 1);
                if ((u == "a")) {
                    kk = "10";
                }
                else if ((u == "b")) {
                    kk = "11";
                }
                else if ((u == "c")) {
                    kk = "12";
                }
                else if ((u == "d")) {
                    kk = "13";
                }
                else if ((u == "e")) {
                    kk = "14";
                }
                else if ((u == "f")) {
                    kk = "15";
                }
                else {
                    kk = u;
                }
                
                if ((u1 == "a")) {
                    k = "10";
                }
                else if ((u1 == "b")) {
                    k = "11";
                }
                else if ((u1 == "c")) {
                    k = "12";
                }
                else if ((u1 == "d")) {
                    k = "13";
                }
                else if ((u1 == "e")) {
                    k = "14";
                }
                else if ((u1 == "f")) {
                    k = "15";
                }
                else if ((u1 == "0")) {
                    p = ee[double.Parse(kk), 0];
                    goto 1;
                }
                else {
                    k = double.Parse(u1);
                }
                
                p = ee[double.Parse(kk), double.Parse(k)];
                1;
                y = this.binaryhex(p);
                2;
                t = (t + y);
                j = (j + 1);
            }
            
            x = t.Substring(0, 8);
            n = t.Substring(8, 8);
            r = t.Substring(16, 8);
            v = t.Substring(24, 8);
            d = (d + this.xorhex(x, n, r, v));
            jj = (jj + 1);
            j = 0;
            t = "";
        }
        
        return d;
    }
    
    public string subbyte(string a) {
        string[,] u;
        "63";
        "7c";
        "77";
        "7B";
        "F2";
        "6B";
        "6F";
        "C5";
        "30";
        "01";
        "67";
        "2B";
        "FE";
        "D7";
        "AB";
        "76";
        "CA";
        "82";
        "C9";
        "7D";
        "FA";
        "59";
        "47";
        "F0";
        "Ad";
        "D4";
        "A2";
        "AF";
        "9C";
        "A4";
        "72";
        "C0";
        "B7";
        "FD";
        "93";
        "26";
        "36";
        "3F";
        "F7";
        "CC";
        "34";
        "A5";
        "E5";
        "F1";
        "71";
        "D8";
        "31";
        "15";
        "04";
        "C7";
        "23";
        "C3";
        "18";
        "96";
        "05";
        "9A";
        "07";
        "12";
        "80";
        "E2";
        "EB";
        "27";
        "B2";
        "75";
        "09";
        "83";
        "2C";
        "1A";
        "1B";
        "6E";
        "5A";
        "A0";
        "52";
        "3B";
        "D6";
        "B3";
        "29";
        "E3";
        "2F";
        "84";
        "53";
        "D1";
        "00";
        "ED";
        "20";
        "FC";
        "B1";
        "5B";
        "6A";
        "CB";
        "BE";
        "39";
        "4A";
        "4C";
        "58";
        "CF";
        "D0";
        "EF";
        "AA";
        "FB";
        "43";
        "4D";
        "33";
        "85";
        "45";
        "F9";
        "02";
        "7F";
        "50";
        "3C";
        "9F";
        "A8";
        "51";
        "A3";
        "40";
        "8F";
        "92";
        "9D";
        "38";
        "F5";
        "BC";
        "B6";
        "DA";
        "21";
        "10";
        "FF";
        "F3";
        "D2";
        "CD";
        "0C";
        "13";
        "EC";
        "5F";
        "97";
        "44";
        "17";
        "C4";
        "A7";
        "7E";
        "3D";
        "64";
        "5D";
        "19";
        "73";
        "60";
        "81";
        "4F";
        "DC";
        "22";
        "2A";
        "90";
        "88";
        "46";
        "EE";
        "B8";
        "14";
        "DE";
        "5E";
        "0B";
        "DB";
        "E0";
        "32";
        "3A";
        "0A";
        "49";
        "06";
        "24";
        "5C";
        "C2";
        "D3";
        "AC";
        "62";
        "91";
        "95";
        "E4";
        "79";
        "E7";
        "C8";
        "37";
        "6D";
        "8D";
        "D5";
        "4E";
        "A9";
        "6C";
        "56";
        "F4";
        "EA";
        "65";
        "7A";
        "AE";
        "08";
        "BA";
        "78";
        "25";
        "2E";
        "1C";
        "A6";
        "B4";
        "C6";
        "E8";
        "DD";
        "74";
        "1F";
        "4B";
        "BD";
        "8B";
        "8A";
        "70";
        "3E";
        "B5";
        "66";
        "48";
        "03";
        "F6";
        "0E";
        "61";
        "35";
        "57";
        "B9";
        "86";
        "C1";
        "1D";
        "9e";
        "E1";
        "F8";
        "98";
        "11";
        "69";
        "D9";
        "8E";
        "94";
        "9B";
        "1E";
        "87";
        "E9";
        "CE";
        "55";
        "28";
        "DF";
        "8C";
        "A1";
        "89";
        "0D";
        "BF";
        "E6";
        "42";
        "68";
        "41";
        "99";
        "2D";
        "0F";
        "B0";
        "54";
        "BB";
        "16";
        string s;
        string ss;
        string aa;
        string a1;
        string f;
        string r;
        s = "";
        f = "";
        int k;
        int l;
        int tt;
        int t1;
        int v;
        int z;
        k = 0;
        l = 4;
        for (v = 1; (v <= a.Length); v = (v + 8)) {
            aa = a.Substring((v - 1), 8);
            s = aa.Substring(0, 4);
            ss = aa.Substring(4, 4);
            tt = this.int(s);
            t1 = this.int(ss);
            r = u[tt, t1];
            z = r.Length;
            if ((z == 1)) {
                r = ("0" + r);
            }
            
            a1 = this.binaryhex(r);
            f = (f + a1);
        }
        
        return f;
    }
    
    public string inverssubbyte(string a) {
        string[,] uu;
        "52";
        "09";
        "6A";
        "D5";
        "30";
        "36";
        "A5";
        "38";
        "BF";
        "40";
        "A3";
        "9E";
        "81";
        "F3";
        "D7";
        "FB";
        "7C";
        "E3";
        "39";
        "82";
        "9B";
        "2F";
        "FF";
        "87";
        "34";
        "8E";
        "43";
        "44";
        "C4";
        "DE";
        "E9";
        "CB";
        "54";
        "7B";
        "94";
        "32";
        "A6";
        "C2";
        "23";
        "3D";
        "EE";
        "4C";
        "95";
        "0B";
        "42";
        "FA";
        "C3";
        "4E";
        "08";
        "2E";
        "A1";
        "66";
        "28";
        "D9";
        "24";
        "B2";
        "76";
        "5B";
        "A2";
        "49";
        "6D";
        "8B";
        "D1";
        "25";
        "72";
        "F8";
        "F6";
        "64";
        "86";
        "68";
        "98";
        "16";
        "D4";
        "A4";
        "5C";
        "CC";
        "5D";
        "65";
        "B6";
        "92";
        "6C";
        "70";
        "48";
        "50";
        "FD";
        "ED";
        "B9";
        "DA";
        "5E";
        "15";
        "46";
        "57";
        "A7";
        "8D";
        "9D";
        "84";
        "90";
        "D8";
        "AB";
        "00";
        "8C";
        "BC";
        "D3";
        "0A";
        "F7";
        "E4";
        "58";
        "05";
        "B8";
        "B3";
        "45";
        "06";
        "D0";
        "2C";
        "1E";
        "8F";
        "CA";
        "3F";
        "0F";
        "02";
        "C1";
        "AF";
        "BD";
        "03";
        "01";
        "13";
        "8A";
        "6B";
        "3A";
        "91";
        "11";
        "41";
        "4F";
        "67";
        "DC";
        "EA";
        "97";
        "F2";
        "CF";
        "CE";
        "F0";
        "B4";
        "E6";
        "73";
        "96";
        "AC";
        "74";
        "22";
        "E7";
        "AD";
        "35";
        "85";
        "E2";
        "F9";
        "37";
        "E8";
        "1C";
        "75";
        "DF";
        "6E";
        "47";
        "F1";
        "1A";
        "71";
        "1D";
        "29";
        "C5";
        "89";
        "6F";
        "B7";
        "62";
        "0E";
        "AA";
        "18";
        "BE";
        "1B";
        "FC";
        "56";
        "3E";
        "4B";
        "C6";
        "D2";
        "79";
        "20";
        "9A";
        "DB";
        "C0";
        "FE";
        "78";
        "CD";
        "5A";
        "F4";
        "1F";
        "DD";
        "A8";
        "33";
        "88";
        "07";
        "C7";
        "31";
        "B1";
        "12";
        "10";
        "59";
        "27";
        "80";
        "EC";
        "5F";
        "60";
        "51";
        "7F";
        "A9";
        "19";
        "B5";
        "4A";
        "0D";
        "2D";
        "E5";
        "7A";
        "9F";
        "93";
        "C9";
        "9C";
        "EF";
        "A0";
        "E0";
        "3B";
        "4D";
        "AE";
        "2A";
        "F5";
        "B0";
        "C8";
        "EB";
        "BB";
        "3c";
        "83";
        "53";
        "99";
        "61";
        "17";
        "2B";
        "04";
        "7E";
        "BA";
        "77";
        "D6";
        "26";
        "E1";
        "69";
        "14";
        "63";
        "55";
        "21";
        "0C";
        "7D";
        string s1;
        string ss1;
        string f;
        string a1;
        string aa1;
        string r1;
        s1 = "";
        f = "";
        int k1;
        int l1;
        int tt1;
        int t11;
        int j;
        int z;
        k1 = 0;
        l1 = 4;
        for (j = 1; (j <= a.Length); j = (j + 8)) {
            aa1 = a.Substring((j - 1), 8);
            s1 = aa1.Substring(0, 4);
            ss1 = aa1.Substring(4, 4);
            tt1 = this.int(s1);
            t11 = this.int(ss1);
            r1 = uu[tt1, t11];
            z = r1.Length;
            if ((z == 1)) {
                r1 = ("0" + r1);
            }
            
            a1 = this.binaryhex(r1);
            f = (f + a1);
        }
        
        return f;
    }
    
    public string shiftrowtransformation(string s) {
        string a;
        string b;
        string c;
        string d;
        a = s.Substring(0, 32);
        b = s.Substring(32, 32);
        c = s.Substring(64, 32);
        d = s.Substring(96, 32);
        string b1;
        string c1;
        string d1;
        string m;
        b1 = this.shift(b, 8, "r");
        c1 = this.shift(c, 16, "r");
        d1 = this.shift(d, 24, "r");
        m = (a 
                    + (b1 
                    + (c1 + d1)));
        return m;
    }
    
    public string inversshiftrowtransformation(string s) {
        string a;
        string b;
        string c;
        string d;
        a = s.Substring(0, 32);
        b = s.Substring(32, 32);
        c = s.Substring(64, 32);
        d = s.Substring(96, 32);
        string b2;
        string c2;
        string d2;
        string m;
        b2 = this.shift(b, 8, "l");
        c2 = this.shift(c, 16, "l");
        d2 = this.shift(d, 24, "l");
        m = (a 
                    + (b2 
                    + (c2 + d2)));
        return m;
    }
    
    public void add(string a, string key) {
        string z;
        string f;
        string k;
        z = "";
        f = "";
        int m;
        z = this.Xor128(a, key);
        for (i = 1; (i <= z.Length); i = (i + 4)) {
            m = this.int(z.Substring((i - 1), 4));
            if ((m == 10)) {
                k = "A";
            }
            else if ((m == 11)) {
                k = "B";
            }
            else if ((m == 12)) {
                k = "C";
            }
            else if ((m == 13)) {
                k = "D";
            }
            else if ((m == 14)) {
                k = "E";
            }
            else if ((m == 15)) {
                k = "F";
            }
            else {
                k = m;
            }
            
            f = (f + k);
        }
        
        string f1;
        string k1;
        f1 = "";
        string m1;
        for (i = 1; (i <= f.Length); i++) {
            m1 = f.Substring((i - 1), 1).ToString;
            if ((m1 == "A")) {
                k1 = "1010";
            }
            else if ((m1 == "B")) {
                k1 = "1011";
            }
            else if ((m1 == "C")) {
                k1 = "1100";
            }
            else if ((m1 == "D")) {
                k1 = "1101";
            }
            else if ((m1 == "E")) {
                k1 = "1110";
            }
            else if ((m1 == "F")) {
                k1 = "1111";
            }
            else {
                k1 = this.tobin4(m1);
            }
            
            f1 = (f1 + k1);
        }
        
        return f1;
    }
    
    public void addinvers(string b, string key) {
        string z;
        z = this.Xor128(b, key);
        return z;
    }
    
    public void mix(string a) {
        int i;
        string r;
        r = "";
        for (i = 1; (i <= 128); i = (i + 32)) {
            r = (r + this.mixcolumns(a.Substring((i - 1), 32)));
        }
        
        return r;
    }
    
    public void mixinvers(string a) {
        int i;
        string r;
        r = "";
        for (i = 1; (i <= 128); i = (i + 32)) {
            r = (r + this.mixcolumnsinverse(a.Substring((i - 1), 32)));
        }
        
        return r;
    }
    
    public void binary(string a) {
        string m;
        m = "";
        int z;
        int z1;
        int n;
        for (i = a.Length; (i <= 1); i = (i + -1)) {
            z = Asc(a.Substring((i - 1), 1));
            for (n = 1; (n <= 8); n++) {
                z1 = (z % 2);
                m = (z1.ToString + m);
                z = z;
                2;
            }
            
        }
        
        return m;
    }
    
    public void aesencryption(string a, string key) {
        object d = this.binary(a);
        a = d;
        string n;
        string v;
        string s;
        string m;
        m = "";
        int round;
        for (round = 1; (round <= 14); round++) {
            n = this.subbyte(a);
            v = this.shiftrowtransformation(n);
            s = this.mix(v);
            m = this.add(s, key);
            a = m;
        }
        
        return m;
    }
    
    public void aesdecryption(string a, string key) {
        string m;
        string s;
        string n;
        string v;
        v = "";
        int round;
        for (round = 1; (round <= 14); round++) {
            m = this.addinvers(a, key);
            s = this.mixinvers(m);
            n = this.inversshiftrowtransformation(s);
            v = this.inverssubbyte(n);
            a = v;
        }
        
        string mm;
        string z;
        z = "";
        int n1;
        int uu;
        for (n1 = 1; (n1 <= v.Length); n1 = (n1 + 8)) {
            mm = v.Substring((n1 - 1), 8);
            uu = this.int(mm);
            z = (z + ((char)(uu)));
        }
        
        return z;
    }
    
    public void completeencryption(string a, string key) {
        string vv;
        string newvv;
        string complete;
        string encryption;
        encryption = "";
        complete = "";
        int length;
        int kk;
        for (ff = 1; (ff <= a.Length); ff = (ff + 16)) {
            vv = a.Substring((ff - 1), 16);
            if ((vv.Length == 16)) {
                encryption = (encryption + this.aesencryption(vv, key));
            }
            else if ((vv.Length < 16)) {
                length = vv.Length;
                kk = (16 - length);
                for (i = 1; (i <= kk); i++) {
                    complete += "0";
                }
                
                newvv = (vv + complete);
                encryption = (encryption + this.aesencryption(newvv, key));
            }
            
        }
        
        return encryption;
    }
    
    public void completedecryption(string a, string key) {
        string decryption;
        string vv;
        string newvv;
        string complete;
        decryption = "";
        complete = "";
        int length;
        int kk;
        for (ff = 1; (ff <= a.Length); ff = (ff + 128)) {
            vv = a.Substring((ff - 1), 128);
            if ((vv.Length == 128)) {
                decryption = (decryption + this.aesdecryption(vv, key));
            }
            else if ((vv.Length < 128)) {
                length = vv.Length;
                kk = (128 - length);
                for (i = 1; (i <= kk); i++) {
                    complete += "0";
                }
                
                newvv = (vv + complete);
                decryption = (decryption + this.aesdecryption(newvv, key));
            }
            
        }
        
        return decryption;
    }
    
    public void bin_word(string t) {
        string mm;
        string z;
        string zz;
        zz = "";
        int uu;
        int n1;
        for (n1 = 1; (n1 <= t.Length); n1 = (n1 + 8)) {
            mm = t.Substring((n1 - 1), 8);
            uu = this.int(mm);
            if ((uu == 0)) {
                z = "";
                goto 1;
            }
            
            z = ((char)(uu));
            1;
            z;
        }
        
        return zz;
    }
    
    private void Button1_Click(object sender, EventArgs e) {
        string f;
        OpenFileDialog1.InitialDirectory = "e:\\";
        OpenFileDialog1.FileName = "open a file...";
        OpenFileDialog1.Filter = "only text files (*.txt)| *.txt";
        OpenFileDialog1.ShowDialog();
        IO.StreamReader r = new IO.StreamReader(OpenFileDialog1.FileName);
        TextBox1.Text = r.ReadToEnd;
        r.Close();
        //   MsgBox(Len(TextBox1.Text))
        string key = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111" +
        "111111111111111111111111111";
        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();
        f = this.completeencryption(TextBox1.Text, key);
        watch.Stop();
        TextBox4.Text = watch.Elapsed.TotalSeconds;
        System.IO.StreamWriter objWriter = new System.IO.StreamWriter("e:\\file1.txt", false);
        objWriter.WriteLine(f);
        objWriter.Close();
    }
    
    private void Button2_Click(object sender, EventArgs e) {
        string kk;
        string ee;
        string mm;
        OpenFileDialog1.InitialDirectory = "e:\\";
        OpenFileDialog1.FileName = "open a file...";
        OpenFileDialog1.Filter = "only text files (*.txt)| *.txt";
        OpenFileDialog1.ShowDialog();
        IO.StreamReader rr = new IO.StreamReader(OpenFileDialog1.FileName);
        mm = rr.ReadToEnd;
        rr.Close();
        TextBox2.Text = this.bin_word(mm);
        kk = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111" +
        "111111111111111111111111111";
        Stopwatch watch = Stopwatch.StartNew();
        watch.Start();
        ee = this.completedecryption(mm, kk);
        TextBox3.Text = ee.Substring(0, TextBox1.Text.Length);
        watch.Stop();
        TextBox5.Text = watch.Elapsed.TotalSeconds;
    }
    
 
       
    }
}


