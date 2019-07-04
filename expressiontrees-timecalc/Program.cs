using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace expressiontrees_timecalc
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1t - 15m - 15m

            //string expString = "(x, y) => x + y";
            //Func<TimeSpan, TimeSpan, TimeSpan> s = CSharpScript.EvaluateAsync<Func<TimeSpan, TimeSpan, TimeSpan>>(expString).Result;
            //Console.WriteLine(s(new TimeSpan(0,30,0), new TimeSpan(0, 35, 0))); // 4


            Test1();
            Test2();
            Test3();
            Test4();
            Test5();
            Console.WriteLine();
            List<Token> tokens = new List<Token>
            {
                new ValueHourToken(16,30),
                new OperatorSubtractToken(),
                new ValueMinuteToken(30),
                new OperatorSubtractToken(),
                new ValueMinuteToken(15),
                new OperatorSubtractToken(),
                new ValueMinuteToken(5),
                new OperatorSubtractToken(),
                new ValueMinuteToken(1)

            };
            var f = Test6(tokens);
            Console.WriteLine(f());
        }

        private static void CompileExpressionTokens(List<Token> tokens)
        {

            for (int i = 0; i < tokens.Count; i = i + 3)
            {
                ConstantExpression p1 = Expression.Constant(typeof(TimeSpan));
                ConstantExpression p2 = Expression.Constant(typeof(TimeSpan));
                BinaryExpression b1 = null;
                if (tokens[i + 2] is OperatorSubtractToken)
                {
                    b1 = Expression.Subtract(p1, p2);
                }
                if (tokens[i + 2] is OperatorAddToken)
                {
                    b1 = Expression.Subtract(p1, p2);
                }
            }

        }
        private static void CompileExpressionConstant()
        {
            Func<TimeSpan, TimeSpan, TimeSpan> f = (a, b) => a - b - new TimeSpan(0, 15, 0);
            Console.WriteLine(f(new TimeSpan(1, 0, 0), new TimeSpan(0, 30, 0)));

            var p1 = Expression.Parameter(typeof(TimeSpan), "a");
            var p2 = Expression.Parameter(typeof(TimeSpan), "b");
            var p4 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var a1 = Expression.Subtract(p1, p2);
            var a2 = Expression.Subtract(a1, p4);
            var f2 = (Func<TimeSpan, TimeSpan, TimeSpan>)Expression.Lambda(a2, p1, p2).Compile();
            Console.WriteLine(f2(new TimeSpan(1, 0, 0), new TimeSpan(0, 30, 0)));

        }

        private static void Test1()
        {
            var p1 = Expression.Constant(new TimeSpan(15, 55, 0), typeof(TimeSpan));
            var p2 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e1 = Expression.Subtract(p1, p2);
            var f = (Func<TimeSpan>)Expression.Lambda(e1).Compile();
            Console.WriteLine(f());
        }
        private static void Test2()
        {
            var p1 = Expression.Constant(new TimeSpan(15, 55, 0), typeof(TimeSpan));
            var p2 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e1 = Expression.Subtract(p1, p2);
            var p3 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e2 = Expression.Subtract(e1, p3);
            var f = (Func<TimeSpan>)Expression.Lambda(e2).Compile();
            Console.WriteLine(f());
        }
        private static void Test3()
        {
            var p1 = Expression.Constant(new TimeSpan(15, 55, 0), typeof(TimeSpan));
            var p2 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e1 = Expression.Subtract(p1, p2);
            var p3 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e2 = Expression.Subtract(e1, p3);
            var p4 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e3 = Expression.Subtract(e2, p4);
            var f = (Func<TimeSpan>)Expression.Lambda(e3).Compile();
            Console.WriteLine(f());
        }
        private static void Test4()
        {
            var p1 = Expression.Constant(new TimeSpan(15, 55, 0), typeof(TimeSpan));
            var p2 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e1 = Expression.Subtract(p1, p2);
            var p3 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e2 = Expression.Subtract(e1, p3);
            var p4 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e3 = Expression.Subtract(e2, p4);
            var p5 = Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            var e4 = Expression.Subtract(e3, p5);

            var f = (Func<TimeSpan>)Expression.Lambda(e4).Compile();
            Console.WriteLine(f());
        }
        private static void Test5()
        {

            List<BinaryExpression> e = new List<BinaryExpression>();
            e.Add(Expression.Subtract(Expression.Constant(new TimeSpan(15, 55, 0), typeof(TimeSpan)), Expression.Constant(new TimeSpan(0, 5, 0), typeof(TimeSpan))));
            e.Add(Expression.Subtract(e.Last(), Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan))));
            Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            e.Add(Expression.Subtract(e.Last(), Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan))));
            Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            e.Add(Expression.Subtract(e.Last(), Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan))));
            Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan));
            e.Add(Expression.Subtract(e.Last(), Expression.Constant(new TimeSpan(0, 15, 0), typeof(TimeSpan))));
            var f = (Func<TimeSpan>)Expression.Lambda(e.Last()).Compile();
            Console.WriteLine(f());
        }

        private static Func<TimeSpan> Test6(List<Token> tokens)
        {
            List<BinaryExpression> e = new List<BinaryExpression>();
            e.Add(((OperatorToken)tokens[1]).OperatorAsBinaryExpression(((ValueToken)tokens[0]).ValueAsConstantExpression, ((ValueToken)tokens[2]).ValueAsConstantExpression));
            if (tokens.Count > 2)
                for (int i = 3; i < tokens.Count; i += 2)
                    e.Add(((OperatorToken)tokens[i]).OperatorAsBinaryExpression(e.Last(), ((ValueToken)tokens[i + 1]).ValueAsConstantExpression));
            return (Func<TimeSpan>)Expression.Lambda(e.Last()).Compile();
        }
    }

    abstract class Token { }
    abstract class ValueToken : Token
    {
        public TimeSpan Value { get; protected set; }
        public abstract ConstantExpression ValueAsConstantExpression { get; }

    }
    class ValueHourToken : ValueToken
    {
        public ValueHourToken(int hours, int minutes)
        {
            this.Value = new TimeSpan(hours, minutes, 0);
        }

        public ValueHourToken(int value)
        {
            this.Value = new TimeSpan(value, 0, 0);
        }

        public override ConstantExpression ValueAsConstantExpression =>
            Expression.Constant(Value, typeof(TimeSpan));
    }

    class ValueMinuteToken : ValueToken
    {
        public ValueMinuteToken(int value)
        {
            this.Value = new TimeSpan(0, value, 0);
        }

        public override ConstantExpression ValueAsConstantExpression =>
            Expression.Constant(Value, typeof(TimeSpan));

    }
    abstract class OperatorToken : Token
    {
        public abstract BinaryExpression OperatorAsBinaryExpression(Expression a, Expression b);
    }
    class OperatorSubtractToken : OperatorToken
    {
        public override BinaryExpression OperatorAsBinaryExpression(Expression a, Expression b)
        {
            return Expression.Subtract(a, b);
        }
    }
    class OperatorAddToken : OperatorToken
    {
        public override BinaryExpression OperatorAsBinaryExpression(Expression a, Expression b)
        {
            return Expression.Add(a, b);
        }

    }
}
