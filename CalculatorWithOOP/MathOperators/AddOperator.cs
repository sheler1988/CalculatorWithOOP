using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorWithOOP.Base;

namespace CalculatorWithOOP.MathOperators;

// مشق شده Base.MathOperation
// باید داخلش متد اپریت و یه کانستراکتور مت اپریشن رو پیاده سازی کنیم
public class AddOperator : Base.MathOperation
{
	public AddOperator(decimal number1, decimal number2) : base(number1, number2)
	{
	}


	// متد اوورایت کرد چون
	// توی مت اپریشن متد اپریت رو از نوع ابسترکت تعریف کردم
	public override decimal Operate()
	{
		return Number1 + Number2;
	}
}
