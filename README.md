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
2. 部份取代反射(reflection)，傳統上要動態連結DLL時會使用 reflection 技術來處理，程式碼的可讀性常因而下降。有了MEF可以簡化的一些且可讀性更高。

## 設計圖

該商業模組MyBizModule有二個外部元件負責執行演算法的部份，用MyBizPartA、MyBizPartB模擬。  
也使用二種方法進行商業模組與演算法單元的結合。   
方法一：間接再透過 Abstract Factor Pattern 來建構MyBizPartA物件。   
方法二：直接「Import」來建構MyBizPartB。   

![設計簡圖](IoC%20with%20MEF.png)

## 專案總管截圖
![專案總管截圖](project%20explorer%20slice.png)
