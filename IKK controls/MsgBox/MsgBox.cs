﻿using IKK_data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKK_controls
{
    public static class MsgBox
    {
        public static DialogResult Show(string title, string text)
        {
            return new MsgBoxDialog(title, text, new MsgBoxButton[] { new MsgBoxButton("Ok", true, DialogResult.OK) }).ShowDialog();
        }
        public static DialogResult Show(string title, string text, MsgBoxButton[] buttons)
        {
            return new MsgBoxDialog(title, text, buttons).ShowDialog();
        }

        public static Tool ShowToolDialog()
        {
            ToolDialog dialog = new ToolDialog();
            dialog.ShowDialog();
            return dialog.SelectedTool;
        }

        public static Tool ShowToolEditorDialog(Tool tool)
        {
            // TODO
            ToolEditorDialog ted = new ToolEditorDialog();
            return tool;
        }

        public struct MsgBoxButton
        {
            public string Text;
            public bool Raised;
            public DialogResult Result;

            public MsgBoxButton(string text, bool raised, DialogResult result)
            {
                Text = text;
                Raised = raised;
                Result = result;
            }
        }
    }
}
