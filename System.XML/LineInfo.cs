﻿// Decompiled with JetBrains decompiler
// Type: System.Xml.LineInfo
// Assembly: System.Xml.Legacy, Version=4.3.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 04A8895C-E271-4174-9A7C-9A44FF541E99
// Assembly location: C:\Program Files (x86)\Microsoft .NET Micro Framework\v4.3\Assemblies\le\System.Xml.Legacy.dll

namespace System.Xml
{
  internal struct LineInfo
  {
    internal int lineNo;
    internal int linePos;

    public LineInfo(int lineNo, int linePos)
    {
      this.lineNo = lineNo;
      this.linePos = linePos;
    }

    public void Set(int lineNo, int linePos)
    {
      this.lineNo = lineNo;
      this.linePos = linePos;
    }
  }
}
