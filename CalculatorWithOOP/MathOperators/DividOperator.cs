using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithOOP.MathOperators;

public class DividOperator : Base.MathOperation
{
	// مشق شده Base.MathOperation
	// باید داخلش متد اپریت و یه کانستراکتور مت اپریشن رو پیاده سازی کنیم
	public DividOperator(decimal number1, decimal number2) : base(number1, number2)
	{
	}

	// متد اوورایت کرد چون
	// توی مت اپریشن متد اپریت رو از نوع ابسترکت تعریف کردم
	public override decimal Operate()
	{
		return Number1 / Number2;
	}

	// متد ولیدیت رو اینجا اوورایت کردیم و داخلش کفتیم
	//اکر عدد دوم برابر صفر بود یه پیغام خطا بده
	
	// پیغام داخل پروکرم نوشته شده
	public override bool Validate()
	{
		if (base.Number2 == 0) return false;
		else return true;
	}
}
