# 凡人修仙传

A Record of a Mortal's Journey to Immortality

记录学习历程，戒骄戒躁。共勉！

<!---
Template
## Chapter 1
---
### Week 1 (5.23 - 5.29)
### **5.23**
### **Topic**
### **What I've learnt**
### **Notes**
---
-->

## CHAPTER 1 FINDING A NEW JOB 跳槽风云

---

### Week 1 (5.23 - 5.29)

### **5.23**

### **Topic**

- YouTube - Understanding RxJS
- RxJS 6, 7
- Review some .NET/C# interview questions

### **What I've learnt**

- Observable
- Observer
- RxJS changes - Imports - Pipe operator - Renamed operators:
  do() => tap()
  catch() => catchError()
  switch() => switchAll()
  finally() => finalize()
  throw() => throwError()
- SUBJECT (~EventEmitter):
  manually emit values
- .filter(function(value) {}, this)
- .scan()
- .reduce()

### **Notes**

1. [Fix your RxJS 6 Imports & Operators - What's New in RxJS 6?](https://www.youtube.com/watch?v=X9fdpGthrXA&list=PL55RiY5tL51pHpagYcrN9ubNLVXF8rGVi&index=4)

---

### **5.24-5.27**

唉， 还是逃不掉刷题。

### **Topic**

- HackerRank

### **What I've learnt**

- .Substring(int startIndex, int length)
- Convert string to Int: Int32.Parse(firstTwo)
- List.Sort()
- Dictionary.ContainsKey(Key_Value)
- Dictionary.Add(Key, Value)
- Find in Dictionary by Value: Dictionary.FirstOrDefault(x => x.Value == 1).Key
- Find in Dictionary by Key: Dictionary[Key]
- diagonals: 对角线
- c# get absolute value: Math.Abs()
- 2 denmentional list, same as array

### **Notes**

---

### **5.28-5.29**

### **Topic**

- Some C# Fundamentals

### **What I've learnt**

- break; continue;
- String operations:
  - String.Concat() With concat, strings are merged (combined). It is possible to concatenate 2 or more strings with several syntax forms.
  - String.Join(',', str)
  - String.Equals(str)
  - String.IndexOf()
- String formatting
- int.Parse(string, **NumberStyles**)
- Int32.TryParse(string, out outResult)
- ref, out keyword
- C#7: Tuple
- C# OOP:
  - field
  - property
  - protected, private
  - virtual keyword

### **Notes**

---

### Week 2 (5.30 - 6.5)

### **5.30-5.31**

### **Topic**

Review C#

### **What I've learnt**

- value type: pass a copy
- reference type
- .NET Garbage collection: performs on heap
- string
  - .Equals()
  - .Compare()
- string to number
  - TryParse()
- DateTime
  - DateOnly
  - TimeOnly

### **Notes**

---

### **6.1**

### **Topic**

Review C# interview questions

### **What I've learnt**

- Describe boxing and unboxing. Provide an example:

Boxing is an implicit conversion of a value type to the type object or to any interface type implemented by the value type. Boxing a value type creates an object instance containing the value and stores it on the **heap**.

Example:

```c#
int x = 101;
object o = x;  // boxing value of x into object o

o = 999;
x = (int)o;    // unboxing value of o into integer x
```

### **Notes**

---

### **6.3 面试小结**

数据结构和算法优化将是区分初级和中高级程序员的主要因素。\
日后学习重心：

- C#巩固基础
- C#数据结构
- LeeCode 初级算法
- 继续学习.NET, Angular/React 的项目
- 7 月 Renew Azure 证书

---

### Week 2 (6.4)

### **Topic**

### **What I've learnt**

### **Notes**

---
