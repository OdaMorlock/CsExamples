using System;

namespace AnTeckningar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * int[] number = new int[6]
             * 
             * int[6] är en int Array med 6 platser där 0 är låda Ett 
             * 
             * int[] Skapar en array och get number array format
             * 
             * int[] number = {1,2,3,4,5,6} skapar här den en box för varje number och sätter in de.
             * 
             * index = vilken position de har och första boxen börjar med 0 sedan 1 så det går ifrån 0 och vidare 
             * tex   0,             1     ,     2,           3,       4,          5
             *         plats 1#    plats 2#   plats 3#    pats 4# osv
             *         
             * Om man gör en int,string,bool Array så kan den vara ha den typen av format som angivits
             * 
             * Object Array
             * object[] 
             * 
             * Man använder oftare en Class 
             * tex
             * Person[] number =  new Person[6]
             * Detta ger en array med classen Person och skapar 6 stycken Fack som har plats för 6 olika Personer ifrån classen Person
             * 
             * En Array Behöver veta hur mycket plats så om man använder en konstruktion som sedan skapas och anger ett antal så kan jag använda den men inte innan 
             * 
             * int _numberOfSiblings = ; funkar inte för det är inte anget ett antal
             * string[] siblings = new string[_numberOfSibings];
             * 
             * for(var i=0; i<_numberOfSibings; i++)
             * {
             * 
             * }
             * 
             * Sätter i till värde 0 och för varje gång i är minder än numberOfSiblings så lägger den till ett och kör koden under och sedan kör den allt igen så nästa gång är värdet på i 1
             * 
             * ++ betyder plus 1
             * 
             * Post ++i
             * 
             * ++i ökar talet först sedan gör saken
             * i++ gör saken först sedan ökar 
             * 
             * =,==,=<,<= är operators ( bör dubbel kolla eller skapa en privat lista jag kan dubbel kolla)
             * 
             * = tilldella ett värde
             * += lägg til på befitligt värde
             * -= ta bort ifrån befitlingt värde
             * 
             * 
             * ==     Lika med
             * !=     inte lika med
             * <      minder än
             * >      större än
             * <=     minder eller lika med
             * >=     större eller lika med 
             * ||     eller
             * &&     och
             * !      inte
             * 
             * 
             * (// one line comment )
             * (/* muti-line comment */
            /*)
             * 
             * 
             * 
             *  for(var i=0; i<_numberOfSibings; i++)
                    {
                        if (i == 0)
                            Console.Write("What´s your first siblings name? ");
                        else
                            Console.Write("And your next siblings name? ");

                        siblings[i] = Console.ReadLine();
                        
                    }
            med silbings [i] tar den den som i är och lägger i det facket som är med i arrayen så första gången är i = 0 och sätter första siblings namnet i fack 0 ( som är första)
             *                                          
             * for loop ett givet ett givent antal
             * 
             * foreach loop loopar genom så många gånger det finns värden är 
             * 
             * 
             * list<string> listname = new list<string>() innanför <> sätter man vilket format det ska vara
             * var listname = new list<string>() funkar också
             * 
             * .ToLower tvingar ner det till Lägre
             * 
             * If stats 
             * 
             * Om färgen är == Blue så händer det inom Blue
             * 
             * Else if ( färgen == Gul) händer det inom Gul
             * 
             * Else if ( färgen == Gray) händer Gray
             * 
             * Else om inte något av det övre  så händer detta
             * 
             * if stats tar och jämnför med alla alternativ uppifrån ner  och stannar när den når rätt svar
             * 
             * 
             * switch är en form av en If sats som passar bättre med fler fler-alternativ .
             * 
             * Den tittar på alla samtidigt och ser om någon av dom är rätt Färg och tar det Case som är rätt , om inget är rätt går den till Default
             * 
             * Case blue 
             * 
             * Case yellow 
             * 
             * Case Gray
             * 
             * Default( om inget annat är rätt)
             * 
             * 
             * Vill ha Oldest first 
             * 
             * Hans
             * Tommy
             * Anki (Oldest)
             * 
             * så kan man bytta plats , om någon försviner tar den längst ner och åker upp  och man kan ta någon ifrån ett plats och förflytta dem till vilken plast men vill
             * var _oldest = Console.ReadLine(); / Lässer in vem som är oldest
             * var index = siblings.FindIndex(x => x.Contains(_oldest)); / Letar reda på Index plats som har Oldest
             * siblings.RemoveAt(index); / tar bort det at index
             * siblings.Insert(0,_oldest); / lägger till Oldest i plats 0( första)
             * 
             * 
             */
        }
    }
}
