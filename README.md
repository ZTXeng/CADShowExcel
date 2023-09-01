# CADShowExcel
how to show Excel inCAD

第一步：
打开工程文件点击重新生成，或者手动安装缺少的nuget包；
第二步：
添加对应的dll引用，主要是accorengd、acdbmgd、acmgd、AdWindows，这些需要添加自己cad对应版本的；
第三步：
找到工程文件下的autoset.lsp文件，将地址改为项目文件的生成地址；
第四步：
打开cad，输入appload，在设置里面添加autoset.lsp；
第五步：
在visualstudio中设置启动项，并配置启动exe为cad；

下面就可以开始项目文件的调试和代码阅读了~
