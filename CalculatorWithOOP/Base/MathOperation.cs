using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWithOOP.Base;

public abstract class MathOperation
{
	public decimal Number1;
	public decimal Number2;

	// یه کانستراکتور که این دو تا رو به عنوان پارامتر ورودی میکیره
	public MathOperation(decimal number1, decimal number2)
	{
		Number1 = number1;
		Number2 = number2;
	}

	// یک متد که عملیات بین این  دو تا عدد رو اجرا میکنه و برای ما برمیکردونه
	// ابسترک باشه یعنی میخوام توی کلاسهای 
	// چایلد تعریف کردنش اجباری باشه
	
	// یه کلاس پایه بنام مت اپریشن تعریف کردم که دوتا عدد رو به عنوان ورودی میکیره
	// و یه متد ابسترک داریم به نام اوپریت که عملیات رو تو کلاس چایلد پیاده سازی میکنه
	public abstract decimal Operate();

	// 
	public virtual bool Validate()
	{
		return true;
	}
}