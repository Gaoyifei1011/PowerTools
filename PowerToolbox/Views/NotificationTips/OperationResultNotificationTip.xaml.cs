﻿using Microsoft.UI.Xaml.Controls;
using PowerToolbox.Extensions.DataType.Enums;
using PowerToolbox.Services.Root;
using System.ComponentModel;

namespace PowerToolbox.Views.NotificationTips
{
    /// <summary>
    /// 操作完成后应用内通知
    /// </summary>
    public sealed partial class OperationResultNotificationTip : TeachingTip, INotifyPropertyChanged
    {
        private bool _isSuccessOperation;

        public bool IsSuccessOperation
        {
            get { return _isSuccessOperation; }

            set
            {
                if (!Equals(_isSuccessOperation, value))
                {
                    _isSuccessOperation = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsSuccessOperation)));
                }
            }
        }

        private string _operationContent;

        public string OperationContent
        {
            get { return _operationContent; }

            set
            {
                if (!string.Equals(_operationContent, value))
                {
                    _operationContent = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(OperationContent)));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public OperationResultNotificationTip(OperationKind operationKind)
        {
            InitializeComponent();

            if (operationKind is OperationKind.AddDriverAllSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddDriverAllSuccessfully");
            }
            else if (operationKind is OperationKind.AddDriverFailed)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddDriverFailed");
            }
            else if (operationKind is OperationKind.AddDriverPartialSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddDriverPartialSuccessfully");
            }
            else if (operationKind is OperationKind.AddInstallDriverAllSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddInstallDriverAllSuccessfully");
            }
            else if (operationKind is OperationKind.AddInstallDriverFailed)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddInstallDriverFailed");
            }
            else if (operationKind is OperationKind.AddInstallDriverPartialSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("AddInstallDriverPartialSuccessfully");
            }
            else if (operationKind is OperationKind.DeleteDriverAllSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("DeleteDriverAllSuccessfully");
            }
            else if (operationKind is OperationKind.DeleteDriverFailed)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("DeleteDriverFailed");
            }
            else if (operationKind is OperationKind.DeleteDriverPartialSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("DeleteDriverPartialSuccessfully");
            }
            else if (operationKind is OperationKind.DeleteDriverSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("DeleteDriverSuccessfully");
            }
            else if (operationKind is OperationKind.DeleteFileFailed)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("FileDeleteFailed");
            }
            else if (operationKind is OperationKind.FileLost)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("FileLost");
            }
            else if (operationKind is OperationKind.ForceDeleteDriverAllSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("ForceDeleteDriverAllSuccessfully");
            }
            else if (operationKind is OperationKind.ForceDeleteDriverFailed)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("ForceDeleteDriverFailed");
            }
            else if (operationKind is OperationKind.ForceDeleteDriverPartialSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("ForceDeleteDriverPartialSuccessfully");
            }
            else if (operationKind is OperationKind.ForceDeleteDriverSuccessfully)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("ForceDeleteDriverSuccessfully");
            }
            else if (operationKind is OperationKind.InsiderPreviewSettings)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("InsiderPreviewSuccessfully");
            }
            else if (operationKind is OperationKind.LanguageChange)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("LanguageChange");
            }
            else if (operationKind is OperationKind.ListEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("ListEmpty");
            }
            else if (operationKind is OperationKind.MenuDarkThemeIconPathEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuDarkThemeIconPathEmpty");
            }
            else if (operationKind is OperationKind.MenuDefaultIconPathEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuDefaultIconPathEmpty");
            }
            else if (operationKind is OperationKind.MenuLightThemeIconPathEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuLightThemeIconPathEmpty");
            }
            else if (operationKind is OperationKind.MenuProgramPathEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuProgramPathEmpty");
            }
            else if (operationKind is OperationKind.MenuMatchRuleEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuMatchRuleEmpty");
            }
            else if (operationKind is OperationKind.MenuTitleEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("MenuTitleEmpty");
            }
            else if (operationKind is OperationKind.NoOperation)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("NoOperation");
            }
            else if (operationKind is OperationKind.SelectDriverEmpty)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("SelectDriverEmpty");
            }
            else if (operationKind is OperationKind.ShellMenuNeedToRefreshData)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("ShellMenuNeedToRefreshData");
            }
            else if (operationKind is OperationKind.ThemeChangeSameTime)
            {
                IsSuccessOperation = false;
                OperationContent = ResourceService.NotificationTipResource.GetString("ThemeChangeSameTime");
            }
            else if (operationKind is OperationKind.ThemeSwitchSaveResult)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("ThemeSwitchSaveResult");
            }
            else if (operationKind is OperationKind.ThemeSwitchRestoreResult)
            {
                IsSuccessOperation = true;
                OperationContent = ResourceService.NotificationTipResource.GetString("ThemeSwitchRestoreResult");
            }
        }

        public OperationResultNotificationTip(OperationKind operationKind, bool operationResult)
        {
            InitializeComponent();

            if (operationKind is OperationKind.CleanUpdateHistory)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("CleanUpdateHistorySuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("CleanUpdateHistoryFailed");
                }
            }
            else if (operationKind is OperationKind.CheckUpdate)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("NewestVersion");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("NotNewestVersion");
                }
            }
            else if (operationKind is OperationKind.ContextMenuUpdate)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("ContextMenuUpdateSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("ContextMenuUpdateFailed");
                }
            }
            else if (operationKind is OperationKind.Desktop)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("DesktopShortcutSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("DesktopShortcutFailed");
                }
            }
            else if (operationKind is OperationKind.LogClean)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("LogCleanSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("LogCleanFailed");
                }
            }
            else if (operationKind is OperationKind.LoopbackSetResult)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("LoopbackSetResultSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("LoopbackSetResultFailed");
                }
            }
            else if (operationKind is OperationKind.StartScreen)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("StartScreenSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("StartScreenFailed");
                }
            }
            else if (operationKind is OperationKind.Taskbar)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("TaskbarSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("TaskbarFailed");
                }
            }
            else if (operationKind is OperationKind.TerminateProcess)
            {
                if (operationResult)
                {
                    IsSuccessOperation = true;
                    OperationContent = ResourceService.NotificationTipResource.GetString("TerminateProcessSuccessfully");
                }
                else
                {
                    IsSuccessOperation = false;
                    OperationContent = ResourceService.NotificationTipResource.GetString("TerminateProcessFailed");
                }
            }
        }

        public OperationResultNotificationTip(OperationKind operationKind, int successItems, int failedItems)
        {
            InitializeComponent();

            if (operationKind is OperationKind.File)
            {
                IsSuccessOperation = true;
                OperationContent = failedItems is 0 ? string.Format(ResourceService.NotificationTipResource.GetString("FileResultSuccessfully"), successItems) : string.Format(ResourceService.NotificationTipResource.GetString("FileResultFailed"), successItems, failedItems);
            }
            else if (operationKind is OperationKind.IconExtract)
            {
                IsSuccessOperation = true;
                OperationContent = failedItems is 0 ? string.Format(ResourceService.NotificationTipResource.GetString("IconExtractSuccessfully"), successItems) : string.Format(ResourceService.NotificationTipResource.GetString("IconExtractFailed"), successItems, failedItems);
            }
        }
    }
}
