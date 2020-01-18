# TestConnectMysql

## 数据库内容

* 数据库名：testconnect
* 表名：test1
* 字段：user(int)，password(int)；ads(char(40))

## 连接时产生的问题

### 一、项目框架版本不匹配

项目的属性中`.NET Framework`版本应该和项目引用中`MySql.Data.dll`的版本一致，

我使用的时`.NET Framework4.5.1`，所以要用`V4.5.1`的`MySql.Data.dll`，

