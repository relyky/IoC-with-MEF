# IoC-with-MEF
使用MEF實現IoC

# 引言
IoC實現的方法有很多，本人認為MEF是最完美的方法。

# 說明
* [IoC, Inversion of Control, 控制反轉](https://zh.wikipedia.org/wiki/%E6%8E%A7%E5%88%B6%E5%8F%8D%E8%BD%AC)   
IoC的說明請參考[終於搞懂了控制反轉(IoC)](http://relycoding.blogspot.tw/2016/06/ioc.html?q=IoC)。  

* [MEF, Managed Extensibility Framework](https://docs.microsoft.com/zh-tw/dotnet/framework/mef/)  
MEF的說明寫得很多很多很多……。總之，就應用面來說，MEF有二大應用：
1. Plug-in。這正是MEF的賣點。
2. 部份取代反射(reflection)，傳統上要動態連結DLL時會使用 reflection 技術來處理，程式碼的可讀性常因而下降。有了MEF可以簡化的一些，且可讀性更高。

# 設計圖



