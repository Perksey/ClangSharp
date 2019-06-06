﻿using System.Diagnostics;

namespace ClangSharp
{
    internal sealed class DoStmt : Stmt
    {
        public DoStmt(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_DoStmt);
        }
    }
}