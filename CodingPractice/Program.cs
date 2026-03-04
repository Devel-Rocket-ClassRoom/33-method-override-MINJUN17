using System;
using System.IO;
using System.Reflection.Emit;

////1-1

//Parent parent1 = new Parent();
//Parent parent2 = new Child();

//parent1.Work();
//parent2.Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//class Child : Parent
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}

////1-2
//Animal animal = new Animal();
//Animal cat = new Cat();
//animal.Eat();
//cat.Eat();
//class Animal
//{
//    public virtual void Eat()
//    {
//        Console.WriteLine("Animal Eat");
//    }
//}
//class Cat : Animal
//{
//    public override void Eat()
//    {
//        Console.WriteLine("Cat Eat");
//    }
//}

////2
//Child child = new Child();
//child.Say();
//child.Run();
//child.Walk();

//Parent child2 = new Child();
//child2.Say();
//child2.Run();
//child2.Walk();
//class Parent
//{
//    public void Say()
//    {
//        Console.WriteLine("부모 - 안녕하세요");
//    }
//    public void Run()
//    {
//        Console.WriteLine("부모 - 달리다.");
//    }
//    public virtual void Walk()
//    {
//        Console.WriteLine("부모 - 걷다");
//    }
//}
//class Child : Parent
//{
//    public new void Say()
//    {
//        Console.WriteLine("자식 - 안녕하세요");
//    }
//    public new void Run()
//    {
//        Console.WriteLine("자식 - 달리다");
//    }
//    public override void Walk()
//    {
//        Console.WriteLine("자식 - 걷다");
//    }
//}

////3-1
//Calculator cal = new Calculator();
//Console.WriteLine(cal.Add(1, 2));
//Console.WriteLine(cal.Add(2.2, 1.8));
//Console.WriteLine(cal.Add(1, 2, 3)); 
//class Calculator
//{
//    public int Add(int num1, int num2)
//    {
//        return num1 + num2;
//    }
//    public double Add(double num1, double num2)
//    {
//        return num1 + num2;
//    }
//    public int Add(int num1, int num2, int num3)
//    {
//        return num1 + num2 + num3;
//    }
//}
////3-2
//Animal animal1 = new Dog();
//Animal animal2 = new Cat();
//Console.WriteLine("동물이 소리를 낸다.");
//animal1.Speak();
//animal2.Speak();
//class Animal
//{
//    public virtual void Speak()
//    {
//        Console.WriteLine();
//    }
//}
//class Dog : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("멍멍!");
//    }
//}

//class Cat : Animal
//{
//    public override void Speak()
//    {
//        Console.WriteLine("야옹!");
//    }
//}

////4-1
//Parent p = new Child();
//p.Greet();
//class Parent
//{
//    public virtual void Greet()
//    {
//        Console.WriteLine("안녕하세요");
//    }
//}
//class Child : Parent
//{
//    public override void Greet()
//    {
//        base.Greet();
//        Console.WriteLine("반갑습니다");
//    }
//}

////4-2
//new Parent().Work();
//new Child().Work();
//new GrandChild().Work();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//class Child : Parent
//{
//    public override void Work()
//    {
//        base.Work();
//    }
//}
//class GrandChild : Child
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}

////5
//new Parent().Work();
//new Child().Work();
//new GrandChild().Work();
//new GrandChild().Play();
//class Parent
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}
//class Child : Parent
//{
//    public sealed override void Work()
//    {
//        base.Work();
//    }
//}
//class GrandChild : Child
//{
//    public void Play()
//    {
//        Console.WriteLine("프로게이머");
//    }
//}


////6-1
//Person p = new Person();
//Console.WriteLine(p);
//Console.WriteLine(p.ToString());
//class Person
//{
//    public string Name;

//}

////6-2
//Person p = new Person("박용준");
//Console.WriteLine(p.ToString());
//class Person
//{
//    public string Name;
//    public Person(string name)
//    {
//        Name = name;
//    }
//    public override string ToString()
//    {
//        return $"[Person 클래스 : {Name}]";
//    }
//}

////6-3
//Character c = new Character("용사", 10, 100);
//Character m = new Character("마법사", 8, 70);
//Console.WriteLine(c);
//Console.WriteLine(m);
//class Character
//{
//    public string Name;
//    public int Level;
//    public int Health;

//    public Character(string name, int level, int health)
//    {
//        Name = name;
//        Level = level;
//        Health = health;
//    }
//    public override string ToString()
//    {
//        return $"[{Name}] Lv.{Level} HP:{Health}";
//    }
//}

////7-1
//Character warrior = new Warrior("전사", 50);
//Character mage = new Warrior("마법사", 30);
//Character archer = new Warrior("궁수", 40);
//Console.WriteLine(warrior);
//Console.WriteLine(mage);
//Console.WriteLine(archer);
//warrior.Attack();
//mage.Attack();
//archer.Attack();
Character[] characters = new Character[3]
{
   new Warrior("전사", 50),
    new Mage("마법사", 30),
    new Archer("궁수", 40)
};
Console.WriteLine("=== 파티 공격 ===");
foreach (Character member in characters)
{
    member.Attack();
}
class Character
{
    public string Name;
    public int AttackPower;
    public Character(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }
    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다");
    }
    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}
class Warrior : Character
{
    public Warrior(string name, int attackPower) : base(name, attackPower)
    {

    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}
class Mage : Character
{
    public Mage(string name, int attackPower) : base(name, attackPower)
    {

    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower*2}");
    }
}
class Archer : Character
{
    public Archer(string name, int attackPower) : base(name, attackPower)
    {

    }
    public override void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}

