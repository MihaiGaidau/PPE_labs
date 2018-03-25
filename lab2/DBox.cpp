#include <windows.h>
#include "resources.h"

BOOL CALLBACK DboxDlgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	switch (msg)
	{
	case WM_INITDIALOG:

		return TRUE;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
			EndDialog(hwnd, IDOK);
			break;
		case IDCANCEL:
			EndDialog(hwnd, IDCANCEL);
			break;
		}
		break;
	default:
		return FALSE;
	}
	return TRUE;
}

void ShowDBox(HWND hwnd)
{
	DialogBox(GetModuleHandle(NULL), MAKEINTRESOURCE(IDDBOX), hwnd, DboxDlgProc);
}
