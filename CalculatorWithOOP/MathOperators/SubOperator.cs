using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithOOP.MathOperators;

// مشق شده Base.MathOperation
// باید داخلش متد اپریت و یه کانستراکتور مت اپریشن رو پیاده سازی
public class SubOperator : Base.MathOperation
{
	public SubOperator(decimal number1, decimal number2) : base(number1, number2)
	{
	}

	// متد اوورایت کرد چون
	// توی مت اپریشن متد اپریت رو از نوع ابسترکت تعریف کردم
	public override decimal Operate()
	{
		return Number1 - Number2;
	}
}
