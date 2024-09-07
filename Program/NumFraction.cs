namespace Lab1{
    public class NumFraction {
        bool b = false, b1 = false;

        void Reduction(ref int ch, ref int zn){     //out int a, out int b
            
            if(Math.Abs(ch) < Math.Abs(zn)){
                    for(int i = Math.Abs(zn); i > 1; i--){
                        if((ch != 1)&&(ch != -1)){
                            if((ch % i == 0)&& (zn % i == 0)){
                                ch = ch / i;
                                zn = zn / i;
                            }
                        }
                        else
                            break;
                    }
            }
            else if(Math.Abs(ch) > Math.Abs(zn)){
                for(int i = Math.Abs(zn); i > 1; i--){
                    if (zn != 1){
                        if((ch % i == 0)&& (zn % i == 0)){
                            ch = ch / i;
                            zn = zn / i;
                        }
                    }
                    else
                        break;
                }
            }
            else{
                if(ch > 0){
                    ch = 1;
                }
                else
                    ch = -1;
                zn = 1;
            }
            if(((zn < 0)&&(ch < 0)) || ((zn < 0)&&(ch > 0))){
                ch = ch * -1;
                zn = zn * -1;
            }
        }

        // void ComDen(out int a1, out int a2, out int b1, out int b2){
        //     a1
        // }

        private readonly int numerator = 0;
        public int Numerator{
            get
            {
                return numerator;
            }
        }
        private readonly int denominator = 1;
        public int Denominator{
            get
            {
                return denominator;
            }
        }
        public NumFraction(){

            label1:
            try{
                Console.Write("Введите числитель: ");
                numerator = Convert.ToInt32(Console.ReadLine());

            }
            catch {
                Console.WriteLine("Выполнен некорректный ввод. Попробуйте еще раз.\n");
                b1 = true;
            }
            finally{
                if (b1 == true){
                    b1 = false;
                }
                else{
                    vvverx:
                    try{
                        do{
                            if (b == true){
                                Console.WriteLine("Невозможно деление на 0. Введите корректные данные для знаменателя еще раз: ");
                                b = false;
                            }
                                else
                                    Console.Write("\nВведите знаменатель: ");
                            denominator = Convert.ToInt32(Console.ReadLine());
                            if(Denominator == 0)
                                b = true;
                        } while(Denominator == 0);
                        b = true;
                    }
                    catch {
                        Console.WriteLine("Выполнен некорректный ввод. Попробуйте еще раз.\n");
                        goto vvverx;
                    }
                }
            }
            if (b != true)
                goto label1;
        }
        public NumFraction(int ch, int zn){
            numerator = ch;
            if(zn!= 0 ){
                denominator = zn;
            }
            else{
                Console.WriteLine("Невозможно деление на 0. Ошибка работы программы");
                Environment.Exit(0);
            }
        }

        override public string ToString(){
            int ch, zn;
            if((numerator < 0) && (denominator < 0)){
                ch = numerator * -1;
                zn = denominator * -1;
            }
            else if (((numerator > 0) && (denominator > 0))||((numerator < 0) && (denominator > 0))){
                ch = numerator;
                zn = denominator;
            }
            else {
                ch = numerator * -1;
                zn = denominator * -1;
            }
            if((zn != 1)&& (zn != -1)){
                // if(Math.Abs(ch) < Math.Abs(zn)){
                //     for(int i = Math.Abs(zn); i > 1; i--){
                //         if((ch != 1)&&(ch != -1)){
                //             if((ch % i == 0)&& (zn % i == 0)){
                //                 ch = ch / i;
                //                 zn = zn / i;
                //             }
                //         }
                //         else
                //             break;
                //     }
                // }
                // else if(Math.Abs(ch) > Math.Abs(zn)){
                //     for(int i = Math.Abs(zn); i > 1; i--){
                //         if (zn != 1){
                //             if((ch % i == 0)&& (zn % i == 0)){
                //                 ch = ch / i;
                //                 zn = zn / i;
                //             }
                //         }
                //         else
                //             break;
                //     }
                // }
                // else{
                //     ch = 1;
                //     zn = 1;
                // }
                Reduction(ref ch, ref zn);
            }

            if((zn != 1)&& (zn != -1)){
                return Convert.ToString(ch + "/" + zn);
            }
            else if(zn == 1){
                return Convert.ToString(ch);
            }
            else
                return Convert.ToString(- + ch);
        }

         // Console.Clear();

        // string? sr = Console.ReadLine();
        // int num = Convert.ToInt32(Console.ReadLine());

        public static NumFraction operator +(NumFraction chislo1, NumFraction chislo2){
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            // while (b1 != b2) {
            if(b1 != b2){
                bool Bo = false;
                int znak = 1;
                if(b1 < b2){
                    if (b2 > 0)
                        znak = -1;
                    for(int i = znak* b2; b1*i < b2; i++){
                        if (b1*i == b2){
                            b1 = b1 * i;
                            a1 = a1 * i;
                            Bo = true;
                            break;
                        }
                    }
                    
                }
                else{
                    if(b1 > 0)
                        znak = -1;
                    for(int i = znak * b1; b2*i < b1; i++){
                        if (b2*i == b1){
                            b2 = b2 * i;
                            a2 = a2 * i;
                            Bo = true;
                            break;
                        }
                    }
                }
                if(Bo == false){
                    int zapomni = b1;
                    b1 = b1*b2;
                    a1 = a1*b2;

                    b2 = b1;
                    a2 = a2*zapomni;
                }
            }
            
          //  }
            NumFraction chik = new NumFraction(a1+a2, b1);
            return chik;
        }

        public static NumFraction operator -(NumFraction chislo1, NumFraction chislo2){
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            if(b1 != b2){
                int znak = 1;
                bool Bo = false;
                if(b1 < b2){
                    if (b2 > 0)
                        znak = -1;
                    for(int i = znak*b2; i*b1 < b2; i++){
                        if (b1*i == b2){
                            b1 = b1 * i;
                            a1 = a1 * i;
                            Bo = true;
                            break;
                        }
                    }
                    
                }
                else{
                    if(b1 > 0){
                        znak = -1;
                    }
                    for(int i = znak*b1; b2*i < b1; i++){
                        if (b2*i == b1){
                            b2 = b2 * i;
                            a2 = a2 * i;
                            Bo = true;
                            break;
                        }
                    }
                }
                if(Bo == false){
                    int zapomni = b1;
                    b1 = b1*b2;
                    a1 = a1*b2;

                    b2 = b1;
                    a2 = a2*zapomni;
                }
            }
            NumFraction chik = new NumFraction(a1-a2, b1);
            return chik;
        }

        public static NumFraction operator *(NumFraction chislo1, NumFraction chislo2){
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            a1 = a1*a2;
            b1 = b1*b2;
            NumFraction chik = new NumFraction(a1, b1);
            return chik;
        }

        public static NumFraction operator /(NumFraction chislo1, NumFraction chislo2){
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            a1 = a1*b2;
            b1 = b1*a2;
            NumFraction chik = new NumFraction(a1, b1);
            return chik;
        }

        public static NumFraction operator -(NumFraction chislo1){
            int a1, b1;
            a1 = chislo1.numerator;
            b1 = chislo1.denominator;
            chislo1.Reduction(ref a1, ref b1);
            a1 = a1* -1;
            NumFraction chik = new NumFraction(a1, b1);
            return chik;
        }

        public static bool operator >(NumFraction chislo1, NumFraction chislo2){
            if(chislo1 == chislo2){
                return false;
            }
            bool Bool;
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            if(b1 != b2){
                bool Bo = false;
                int znak = 1;
                if(b1 < b2){
                    if (b2 > 0)
                        znak = -1;
                    for(int i = znak* b2; b1*i < b2; i++){
                        if (b1*i == b2){
                            b1 = b1 * i;
                            a1 = a1 * i;
                            Bo = true;
                            break;
                        }
                    }
                    
                }
                else{
                    if(b1 > 0)
                        znak = -1;
                    for(int i = znak * b1; b2*i < b1; i++){
                        if (b2*i == b1){
                            b2 = b2 * i;
                            a2 = a2 * i;
                            Bo = true;
                            break;
                        }
                    }
                }
                if(Bo == false){
                    int zapomni = b1;
                    b1 = b1*b2;
                    a1 = a1*b2;

                    b2 = b1;
                    a2 = a2*zapomni;
                }
            }
            if(a1>a2)
                Bool = true;
            else
                Bool = false;

            return Bool;
        }
        public static bool operator <(NumFraction chislo1, NumFraction chislo2){
            if(chislo1 == chislo2){
                return false;
            }
            return !(chislo1 > chislo2);
        }

        public static bool operator >=(NumFraction chislo1, NumFraction chislo2){
            if(chislo1 == chislo2){
                return true;
            }
            bool Bool;
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            if(b1 != b2){
                bool Bo = false;
                int znak = 1;
                if(b1 < b2){
                    if (b2 > 0)
                        znak = -1;
                    for(int i = znak* b2; b1*i < b2; i++){
                        if (b1*i == b2){
                            b1 = b1 * i;
                            a1 = a1 * i;
                            Bo = true;
                            break;
                        }
                    }
                    
                }
                else{
                    if(b1 > 0)
                        znak = -1;
                    for(int i = znak * b1; b2*i < b1; i++){
                        if (b2*i == b1){
                            b2 = b2 * i;
                            a2 = a2 * i;
                            Bo = true;
                            break;
                        }
                    }
                }
                if(Bo == false){
                    int zapomni = b1;
                    b1 = b1*b2;
                    a1 = a1*b2;

                    b2 = b1;
                    a2 = a2*zapomni;
                }
            }
            if(a1>=a2)
                Bool = true;
            else
                Bool = false;

           return Bool;
        }
        public static bool operator <=(NumFraction chislo1, NumFraction chislo2){
            if(chislo1 == chislo2){
                return true;
            }
            else
               return !(chislo1 >= chislo2);
        }

        public static bool operator == (NumFraction chislo1, NumFraction chislo2){
            bool Bool;
            int a1, b1, a2, b2;
            a1 = chislo1.numerator;
            a2 = chislo2.numerator;
            b1 = chislo1.denominator;
            b2 = chislo2.denominator;
            chislo1.Reduction(ref a1, ref b1);
            chislo2.Reduction(ref a2, ref b2);
            if(b1 != b2){
                bool Bo = false;
                int znak = 1;
                if(b1 < b2){
                    if (b2 > 0)
                        znak = -1;
                    for(int i = znak* b2; b1*i < b2; i++){
                        if (b1*i == b2){
                            b1 = b1 * i;
                            a1 = a1 * i;
                            Bo = true;
                            break;
                        }
                    }
                    
                }
                else{
                    if(b1 > 0)
                        znak = -1;
                    for(int i = znak * b1; b2*i < b1; i++){
                        if (b2*i == b1){
                            b2 = b2 * i;
                            a2 = a2 * i;
                            Bo = true;
                            break;
                        }
                    }
                }
                if(Bo == false){
                    int zapomni = b1;
                    b1 = b1*b2;
                    a1 = a1*b2;

                    b2 = b1;
                    a2 = a2*zapomni;
                }
            }
            if(a1==a2)
                Bool = true;
            else
                Bool = false;

            return Bool;
        }
        public static bool operator !=(NumFraction chislo1, NumFraction chislo2){
            return !(chislo1 == chislo2);
        }

        
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            NumFraction other = (NumFraction)obj;
            return this == other;
        }        

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }
    }
}