// Dialog1.cpp : implementation file
//

#include "pch.h"
#include "MFCLibrary1.h"
#include "Dialog1.h"
#include "afxdialogex.h"
#include <afxwinforms.h>
#include "..\CppCliInterop\CppCliInterop.h"

//#define DllUseWinFormsControl

class WinFormsControlHost
{
public:
#ifdef DllUseWinFormsControl
	CWinFormsControl<ManagedLibraryCore::UserControl1> m_ctrl1;
#endif
};

// Dialog1 dialog

IMPLEMENT_DYNAMIC(Dialog1, CDialog)

Dialog1::Dialog1(CWnd* pParent /*=nullptr*/)
	: CDialog(IDD_DIALOG1, pParent)
{

}

Dialog1::~Dialog1()
{
}

void Dialog1::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
#ifdef DllUseWinFormsControl
	DDX_ManagedControl(pDX, IDC_STATIC_PH_FORMS, m_winFormsControlHost->m_ctrl1);
#endif
}


BEGIN_MESSAGE_MAP(Dialog1, CDialog)
	ON_BN_CLICKED(IDC_BUTTON_SHOW_FORM, &Dialog1::OnBnClickedButtonShowForm)
END_MESSAGE_MAP()

void Dialog1::ShowDoModal()
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());
	Dialog1 dlg1;
	dlg1.DoModal();
}

BOOL Dialog1::OnInitDialog()
{
	CDialog::OnInitDialog();

	cppCli = std::make_shared<CppCliInterop>();
	m_winFormsControlHost = std::make_shared<WinFormsControlHost>();
	return TRUE;  
}


void Dialog1::OnBnClickedButtonShowForm()
{
	cppCli->ShowForm();
}
