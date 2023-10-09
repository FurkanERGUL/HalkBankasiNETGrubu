namespace _27_EF_LinqQueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List kavramlarını araştır!!
            //Collection-IEnumerable, IQuerable-IList

            //Query syntax Sorgu veritabanında sorgu yapmak için TSQL komutlarını VS üzerinden kullanabilmeyi sağlar
            IList<Person> personList = new List<Person>()
            {
                new Person(){PersonID=1, PersonName="John", PersonAge=18, PersonCity="İstanbul"},
                new Person(){PersonID=2, PersonName="Steve", PersonAge=25, PersonCity="İstanbul"},
                new Person(){PersonID=3, PersonName="Steve", PersonAge=15, PersonCity="İstanbul"},
                new Person(){PersonID=4, PersonName="Ram", PersonAge=20, PersonCity="Ankara"},
                new Person(){PersonID=5, PersonName="Ron", PersonAge=19, PersonCity="İzmir"}

            };

            //Lin Query Syntax: Sorgu dizimi from anahtar kelimesi ile başlar ve select anahtar kelimesi ile biter
            #region Select

            // select * from person
            var select1 = from p in personList select p;

            //Select PersonName,PersonCity from Person
            var selectColumn1 = from p in personList select new { p.PersonName, p.PersonCity };


            

            foreach (var person in select1)
            {
                Console.WriteLine($"Query Syntax ID: {person.PersonID} Name: {person.PersonName} Age:{person.PersonAge} Person City: {person.PersonCity}");
            }

            foreach (var person in selectColumn1)
            {
                Console.WriteLine($"Query Syntax Name: {person.PersonName} Person City: {person.PersonCity}");
            }


            //Method Syntax
            //Select * from Person
            var select2 = personList.ToList();
            foreach (var person in select2)
            {
                Console.WriteLine($"Method Syntax ID:{person.PersonID} Name: {person.PersonName} Age: {person.PersonAge} City: {person.PersonCity}");
            }

            var selectColumn2 = personList.Select(p => new { p.PersonName,p.PersonCity });
            foreach (var item in selectColumn2)
            {
                Console.WriteLine($"Method syntax Name: {item.PersonName} City: {item.PersonCity}");
            }
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Where
            //Query Syntax 
            var where1 = from p in personList where p.PersonAge > 12 && p.PersonAge < 20 select p;

            foreach (var person in where1)
            {
                Console.WriteLine($"Query syntax Where: Name: {person.PersonName} Age: {person.PersonAge}");
            }

            //Method Syntax
            var where2 = personList.Where(p => p.PersonAge > 12 && p.PersonAge < 20);
            foreach (var person in where2)
            {
                Console.WriteLine($"Method Syntax: Name {person.PersonName} Age: {person.PersonAge}");
            }

            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Order By

            //QuerySyntax
            var orderBy1 = from p in personList orderby p.PersonName select p;
            var orderByDesc1 = from p in personList orderby p.PersonName descending select p;

            foreach (var person in orderBy1)
            {
                Console.WriteLine($"Query syntax: Name:{person.PersonName} Age:{person.PersonAge}");
            }
            foreach (var person in orderByDesc1)
            {
                Console.WriteLine($"Query syntax: Name:{person.PersonName} Age:{person.PersonAge}");
            }

            Console.WriteLine("\n**************\n");

            //Method Syntax
            var orderBy2 = personList.OrderBy(p => p.PersonName);
            var orderByDesc2 = personList.OrderByDescending(p => p.PersonName);
            foreach (var person in orderBy2)
            {
                Console.WriteLine($"Method syntax: Name:{person.PersonName} Age:{person.PersonAge}");
            }
            foreach (var person in orderByDesc2)
            {
                Console.WriteLine($"Method syntax: Name:{person.PersonName} Age:{person.PersonAge}");
            }
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Group By
            var groupBy1 = from p in personList group p by p.PersonAge;

            var groupBy2 = personList.GroupBy(p => p.PersonAge);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Any
            //Verilen şarta uyan bir eleman var mı kontrol eder.
            bool any1 = personList.Any(p => p.PersonCity == "İstanbul");
            Console.WriteLine(any1);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Contains
            //Contains koleksiyonda belirtilen bie eleman var mı diye sorar ve bool döner
            Person person1 = new Person() { PersonID= 0, PersonName="Steve", PersonAge=25, PersonCity="İstanbul" };
            bool contains1 = personList.Contains(person1);
            Console.WriteLine(contains1);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Average
            var avg = personList.Average(p => p.PersonAge);
            Console.WriteLine(avg);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Count
            var count = personList.Count();
            Console.WriteLine(count);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Max-Min
            var max = personList.Max(p => p.PersonAge);
            Console.WriteLine(max);
            var min = personList.Min(p => p.PersonAge);
            Console.WriteLine(min);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Sum
            var sum = personList.Sum(p => p.PersonID);
            Console.WriteLine(sum);
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Take
            // İlk öğeden başlayarak belirtilen sayıda öğeyi döndürür.
            var take = personList.Take(3);
            foreach (var item in take)
            {
                Console.WriteLine(item.PersonName);
            }

            Console.WriteLine("\n************************************\n");

            //TakeWhile belirtilen koşul gerçekleşene kadar
            var takeWhile = personList.TakeWhile(p=> p.PersonCity == "İstanbul");
            foreach (var item in takeWhile)
            {
                Console.WriteLine(item.PersonName);
            }

            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Skip
            //İlk öğeden başlayarak belirtilen sayıda öğeyi atlar.
            var skip = personList.Skip(3);
            foreach (var item in skip)
            {
                Console.WriteLine(item.PersonName);
            }
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region First-FirstOrDefault
            //First: İlk öğeyi veya koşulu sağlayan ilk öğeyi döndürür
            //Index aralığının dışındaysa exception döndürür.
            //FirstOrDefault: Bir koleksiyonun ilk öğesini veya bir koşulu sağlayan ilk öğeyi döndürür.
            //Index aralığının dışındaysa default değer döndürür.

            //var first1 = personList.First();
            //Console.WriteLine(first1);

            //Console.WriteLine("\n*****************\n");

            //var first2 = personList.First(p=>p.PersonName =="Steve");
            //Console.WriteLine($"First: {first2.PersonName} ID: {first2.PersonID}");

            //Console.WriteLine("\n*****************\n");

            //var first3 = personList.FirstOrDefault();
            //var first4 = personList.FirstOrDefault(p => p.PersonName == "Fatih");
            //Console.WriteLine($"First {first4.PersonName} ID: {first4.PersonID}");

            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Last-LastOrDefault
            //First: İlk öğeyi veya koşulu sağlayan ilk öğeyi döndürür
            //Index aralığının dışındaysa exception döndürür.
            //FirstOrDefault: Bir koleksiyonun ilk öğesini veya bir koşulu sağlayan ilk öğeyi döndürür.
            //Index aralığının dışındaysa default değer döndürür.

            var last1 = personList.Last();
            Console.WriteLine(last1);

            Console.WriteLine("\n*****************\n");

            var last2 = personList.Last(p => p.PersonName == "Steve");
            Console.WriteLine($"First: {last2.PersonName} ID: {last2.PersonID}");

            Console.WriteLine("\n*****************\n");

            var last3 = personList.FirstOrDefault();
            var last4 = personList.FirstOrDefault(p => p.PersonName == "Steve");
            Console.WriteLine($"First {last4.PersonName} ID: {last4.PersonID}");

            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Single-SingleOrDefault
            //Single bir koleksiyondaki tek öğeyi veya bir koşulu sağlayan tek öğeyi döndürür. Eğer bulamazsa InvalidOperationException döndürür.

            //var single1 = personList.Single();
            var single2 = personList.Single(p => p.PersonName == "Ram");
            Console.WriteLine($"Single {single2.PersonName}");
            #endregion

            Console.WriteLine("\n******************************************\n");

            #region Join
            List<Student> students = new List<Student>()
            {
                new Student () { StudentID=1, StudentName = "Elif", StandardID=1 },
                new Student () { StudentID=2, StudentName = "Fevzi", StandardID=1 },
                new Student () { StudentID=3, StudentName = "Naime", StandardID=1 },
                new Student () { StudentID=4, StudentName = "Yasin", StandardID=2 },
                new Student () { StudentID=5, StudentName = "Mehmet Ali", StandardID=2 }
            };

            List<Standard> standards = new List<Standard>()
            {
                new Standard () { StandardID=1,StandardName="Standard1"},
                new Standard () { StandardID=2,StandardName="Standard2"},
                new Standard () { StandardID=3,StandardName="Standard3"}
            };

            //Method Syntax
            var innerJoin1 = students.Join//Outer join
                (
                    standards, //İnner Join
                    student => student.StandardID, //Outer key selector
                    standard => standard.StandardID, //Inner key selector
                    (student, standard)=> new
                    {
                        StudentName = student.StudentName,
                        StandardName = standard.StandardName
                    }
                );
            foreach (var item in innerJoin1)
            {
                Console.WriteLine($"Student name: {item.StudentName}, Standart name {item.StandardName}");
            }

            //Query Syntax
            var innerJoin2 = from student in students
                             join standard in standards
                             on student.StandardID equals standard.StandardID
                             select new
                             {
                                 studentName = student.StudentName,
                                 standardName = standard.StandardName
                             };
            foreach (var item in innerJoin2)
            {
                Console.WriteLine($"Student name {item.studentName}, Standard name {item.standardName}");
            }

            #endregion
        }
    }
}