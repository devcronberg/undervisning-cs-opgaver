using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace expressiontrees_timecalc
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1t - 15m - 15m

            string expString = "(x, y) => x + y";
            Func<TimeSpan, TimeSpan, TimeSpan> s = CSharpScript.EvaluateAsync<Func<TimeSpan, TimeSpan, TimeSpan>>(expString).Result;
            Console.WriteLine(s(new TimeSpan(0,30,0), new TimeSpan(0, 35, 0))); // 4

            

            //List<Token> tokens = new List<Token>
            //{
            //    new ValueHourToken(1),
            //    new OperatorSubtractToken(),
            //    new ValueMinuteToken(30),
            //    new OperatorSubtractToken(),
            //    new ValueMinuteToken(15)
            //};
            ////CompileExpressionConstant();
            //CompileExpressionTokens(tokens);
        }

        private static void CompileExpressionTokens(List<Token> tokens)
        {

            for (int i = 0; i < tokens.Count; i=i+3)
            {
                ConstantExpression p1 = Expression.Constant(typeof(TimeSpan));
                ConstantExpression p2 = Expression.Constant(typeof(TimeSpan));
                BinaryExpression b1 = null;
                if (tokens[i + 2] is OperatorSubtractToken) {
                    b1 = Expression.Subtract(p1, p2);
                }
                if (tokens[i + 2] is OperatorAddToken) {
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
    }

    abstract class Token { }
    abstract class ValueToken : Token {
        public int Value { get; protected set; }
    }
    class ValueHourToken : ValueToken {
        public ValueHourToken(int value)
        {
            this.Value = value;
        }
    }
    class ValueMinuteToken : ValueToken {
        public ValueMinuteToken(int value)
        {
            this.Value = value;
        }
    }
    abstract class OperatorToken : Token { }
    class OperatorSubtractToken : OperatorToken { }
    class OperatorAddToken : OperatorToken { }
}
