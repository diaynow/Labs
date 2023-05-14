using lab8event;

Calc calculator=new Calc();
calculator.Add+=calculator.MathAdd;
calculator.Sub+=calculator.MathSub;
calculator.Mult+=calculator.MathMult;
calculator.Div+=calculator.MathDiv;

calculator.Invokeadd(1,2);
calculator.Invokesub(5,1);
calculator.Invokemult(4,3);
calculator.Invokediv(10,2);
