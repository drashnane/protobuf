魔改自3.5.1以适应项目需求



Google.Protobuf
===
1. 添加Unity工程，生成unity net35 dll
2. MessageParser<T>.pool 避免gc alloc，需要在逻辑层管理release
3. ByteString
    * ByteString 自定义长度`new ByteStream(buffer, length)`，与pool配合避免gc alloc
    * ByteString.streamPool(MergeFrom时使用)
    * byteString.GetBuffer()

protoc修改
===
1. 文件名、类名、变量名、枚举名都保持原样，不改成驼峰，不删除下划线。
2. 变量名、枚举名前全部加@，支持保留字做变量名。
3. 删除嵌套的Types类，嵌套类不放在Types类里，直接放在类里。
4. 为Pool支持添加Clear方法