## 一、 Homework1
****
#### 技术思路：
可通过System.Console.BackgroundColor来改变命令行的颜色。
也可通过System.Console.ResetColor()来恢复设置。
#### 运行结果：
![](https://github.com/cxdzb/homework/blob/master/result/h1-1.png?raw=true)
## 二、 Homework2
****
### 1. HelloWorld1
#### 技术思路：
创建HelloWorld类，重写其构造函数，使之每次调用都会输出“Hello world!”;
在Main函数中加入命令行参数args，实例化HelloWorld后，当无参数时输出“No args!”，有参数时输出参数（无个数限制）。
#### 运行结果：
###### 无参数：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-1-1.png?raw=true)
###### 有参数：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-1-2.png?raw=true)
****
### 2. HelloWorld2
#### 技术思路：
创建HelloWorld类并声明静态方法Print，默认参数为arg=" No args!"；
在Main函数中加入命令行参数args，当无参数时无参调用Print输出“Hello world! No args!”，有参数时迭代调用Print并传入参数输出“Hello world! (参数)...”。
#### 运行结果：
###### 无参数：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-2-1.png?raw=true)
###### 有参数：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-2-2.png?raw=true)
****
### 3. HelloWorld3
#### 技术思路：
新建项目后，在<Grid></Grid>中加入一个<TextBlock>并设置Text为“Hello World!”，设置好一系列参数后运行。
#### 运行结果：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld3.png?raw=true)
****
### 4. HelloWorld4
#### 技术思路：
新建项目后，添加多个System.Windows.Forms.Label，并将其内容修改为“Hello World!”，并赋予不同的颜色。
#### 运行结果：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld4.png?raw=true)
****
### 5. HelloWorld5
#### 技术思路：
创建一个android项目，添加一个文本框，将其显示的字符改为“Hello World!”，运行。
#### 运行结果：
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-5-1.png?raw=true)
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-5-2.png?raw=true)
![](https://github.com/cxdzb/homework/blob/master/result/helloworld-5-3.png?raw=true)
****
## 三、 Homework3
****
#### 技术思路：
整个程序用于计算小费tip

添加Grid，在Grid中添加三个RowDefinitions将Grid分为三个部分。
第一二部分各添加一个TextBlock，定义Text内容为标题和输入提示。
第三部分添加一个StackPanel，使结构更规则，其中分为四个小部分。首先是TextBlock和TextBox，TextBox用于输入；然后是一个TextBlock和三个RadioButton，RadioButton用于选择利率；后两部份各添加了两个TextBlock，一个用于输出tip，一个用于输出total。

定义四个事件，前三个amountTextBox_LostFocus、billAmountTextBox_TextChanged、amountTextBox_GotFocus分别用于光标未点的情况、文本改变的情况和光标点击的情况，最后一个RadioButton_Click用于利率的选择。billAmountTextBox_TextChanged和RadioButton_Click中都调用了performCalculation这个计算利率并输出的函数。
Tip类，定义了相关的属性和计算方法CalculateTip，在初始化时创建，被performCalculation调用。
#### 运行结果：
![](https://github.com/cxdzb/homework/blob/master/result/h3-1.png?raw=true)
![](https://github.com/cxdzb/homework/blob/master/result/h3-2.png?raw=true)
