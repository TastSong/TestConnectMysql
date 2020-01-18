# TestConnectMysql

## 数据库内容

* 数据库名：testconnect
* 表名：test1
* 字段：user(int)，password(int)；ads(char(40))

## 连接时产生的问题

### 一、项目框架版本不匹配

项目的属性中`.NET Framework`版本应该和项目引用中`MySql.Data.dll`的版本一致，

我使用的时`.NET Framework4.5.1`，所以要用`V4.5.1`的`MySql.Data.dll`，在安装MySQL的

时候一般只会安装最新的`Connect Net`所以一般不会和你的`.NET Framework`相匹配，[这里](https://github.com/TastSong/TestConnectMysql/tree/master/MySql.Data.dll)提供了

各个版本的`MySql.Data.dll`。

### 二、打开数据库异常

调用`open()`函数时产生异常，此处需要添加`try`，`catch`语句，就可以消除异常。

### 三、数据库操作语句对应

* 在执行查找操作时，要使用`ExecuteReader()` 函数执行         
* 在执行增加操作时，要使用`ExecuteNonQuery()`函数执行    

### 四、MySQL版本问题

因为在`MySQL8`以后的版本字符串默认编码不是`UTF8`,但是VS2013用的是`UTF8`，而且更改MySQL的

默认编码太麻烦，所以我重新安装了`5.6.4.7`版本的`MySQL`，此处给出安装包。











































