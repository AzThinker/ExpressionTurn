Lambda表达式转SQL语句类库

一、可以达到的功能

本功能类库主要提供给代码中使用Lambda表达式，后需转成SQL的条件语句这一需求

二、不能做的

1、本类库不能解析Linq语句

2、不能解析SQL中的Select部分
  
例：
class A
{
    public Int16 Id { get; set; }
    public string name { get; set; }
    public string sex { get; set; }
}
-
AtkExpConditions<A> expa = new AtkExpConditions<A>();
expa.AddAndWhere(s => s.Id == 123 && s.name.Contains("a"), AtkAlias.a2);
expa.UpdateFields(s => new { s.Id, s.sex }, AtkAlias.a2);
  
结果生成下列两个语句：
1、Where (([a2].[Id] = 123) and ([a2].[name] LIKE '%' + 'a' + '%'))
2、[a2].[Id] = @Id,[a2].[sexA] = @sex

QQ：344709752


  

  
  