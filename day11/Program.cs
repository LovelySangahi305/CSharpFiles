// See https://aka.ms/new-console-template for more information

using day11;

Console.WriteLine("operator overloading!");
OperatorPlus obj1 = new OperatorPlus();
obj1.GetDetails();   
OperatorPlus obj2 = new OperatorPlus();
obj2.GetDetails();  
OperatorPlus obj3 = new OperatorPlus();

obj3.num = obj1.num + obj2.num;
obj3.Display();
obj3.num = obj1.num - obj2.num;
obj3.Display();

//obj3 = obj1.Add(obj2);
//obj3.Display();

//obj3 = obj1 + obj2;
//obj3.Display();

Incrementoverload obj4 = new Incrementoverload();
obj1.GetDetails();
Incrementoverload obj5 = new Incrementoverload();
obj5 = obj4++;
obj5.Display();
Incrementoverload obj8 = new Incrementoverload();
obj8.GetDetails();
Incrementoverload obj9 = new Incrementoverload();
obj9 = obj8--;
obj9.Display();

OperatorGreater obj6 = new OperatorGreater();
obj6.GetDetails();
OperatorGreater obj7 = new OperatorGreater();
obj7.GetDetails();
if (obj6 > obj7)
    Console.WriteLine("obj6 {0} is greatest", obj6.num);
else
    Console.WriteLine("obj7 {0} is greatest", obj7.num);


//Console.WriteLine("_________Basic Delegate Program of Calculator________");
//Delegatebasic c1 = new Delegatebasic();
//MyDelegate obj = new MyDelegate(c1.Add); //Step2: Create an instance of delegate
//int result = obj.Invoke(10, 20); // Step3: Invoke
//int result2 = obj(10, 30);
//obj += new MyDelegate(c1.Substract);
//int result3 = obj.Invoke(10, 20);  
//int result4 = obj(10, 30);

//Console.WriteLine("RESULT OF ADD DELEGATE THROUGH INVOKE : {0}", result);
//Console.WriteLine("RESULT OF ADD DELEGATE THROUGH OBJECT :  {0}", result2);
//Console.WriteLine("RESULT OF SUBTARCT DELEGATE THROUGH INVOKE :  {0}", result3);
//Console.WriteLine("RESULT OF SUBTRACT DELEGATE THROUGH OBJECT :  {0}", result4);

//Console.WriteLine("_________Delegate Program of Calculator Through User Input ________");
//int option, result = 0;
//DelegateCalc obj = new DelegateCalc();
//MyDelegate1 delegate1;
//Console.WriteLine("1.Add \n2.Substract \n3.Multiply \n4.Divide");
//Console.WriteLine("Select an option");
//option = Convert.ToInt32(Console.ReadLine());

//switch (option)
//{
//    case 1:

//        delegate1 = new MyDelegate1(obj.Add);
//        //delegate1 += new MyDelegate1(obj.Multiply);
//        result = delegate1(10, 20);
//        break;
//    case 2:

//        delegate1 = new MyDelegate1(obj.Substract);
//        result = delegate1.Invoke(100, 20);
//        break;

//    case 3:

//        delegate1 = new MyDelegate1(obj.Multiply);
//        result = delegate1(10, 20);
//        break;

//    case 4:

//        delegate1 = new MyDelegate1(obj.Divide);
//        result = delegate1(100, 20);
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}
//Console.WriteLine($"Result = {result}");

//Console.WriteLine("_________Delegate Program of Calculator Through LAMBDA EXPRESSION ________");
//int option, result = 0;
//Lambdadelegate obj = new Lambdadelegate();
//MyDel del1;
//Console.WriteLine("1.Add \n2.Substract \n3.Multiply \n4.Divide");
//Console.WriteLine("Select an option");
//option = Convert.ToInt32(Console.ReadLine());

//switch (option)
//{
//    case 1:

//        del1 =  delegate (int a, int b) // anonymous 
//        {
//            return a + b;
//        };
//        result = del1(10, 20); 
//        break;

//    case 2:

//        del1 = (int a, int b) => a - b; // lambda expression
//        result = del1.Invoke(100, 20);
//        break;

//    case 3:

//        del1 = new MyDel(obj.Multiply);
//        result = del1(10, 20);
//        break;

//    case 4:

//        del1 = new MyDel(obj.Divide);
//        result = del1(100, 20);
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}
//Console.WriteLine($"Result = {result}");

//Console.WriteLine("_____LINQ QUERY AND METHODS_________");
//Linqquery lq = new Linqquery();
//lq.displayarr();
//lq.displayeven();
//lq.displaygreater();
//lq.displaynames();
//Linqmethod lm = new Linqmethod();
//lm.displayarray();
//lm.displayeven();   
//lm.displaygreater();
//lm.displayNames();