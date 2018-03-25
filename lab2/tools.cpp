#include "tools.h"
#include "resources.h"
HMENU MakeMenu(HWND hwnd){
    HMENU myMenu = CreateMenu();
    HMENU FileMenu = CreateMenu();
    HMENU EditMenu = CreateMenu();
    HMENU HelpMenu = CreateMenu();
    HMENU ViewMenu = CreateMenu();

    AppendMenu(myMenu, MF_POPUP, (UINT_PTR)FileMenu,"File");
    AppendMenu(myMenu,MF_POPUP,(UINT_PTR)EditMenu,"Edit");
    AppendMenu(myMenu, MF_POPUP,(UINT_PTR)ViewMenu,"View");
    AppendMenu(myMenu, MF_POPUP,(UINT_PTR)HelpMenu,"Help");


    AppendMenu(FileMenu, MF_STRING, NEW_FROM_FILE, "New");
    AppendMenu(FileMenu, MF_SEPARATOR,NULL,NULL);
    AppendMenu(FileMenu, MF_STRING, SAVE_FROM_FILE,"Save");
    AppendMenu(FileMenu, MF_STRING, OPEN_FROM_FILE,"Open");
    AppendMenu(FileMenu, MF_POPUP,(UINT_PTR)EditMenu,"Edit");
    AppendMenu(FileMenu, MF_SEPARATOR,NULL,NULL);
    AppendMenu(FileMenu, MF_STRING,EXIT_FROM_FILE,"Exit");

    AppendMenu(EditMenu,MF_STRING,COPY_FROM_EDIT,"Copy");
    AppendMenu(EditMenu,MF_STRING,PASTE_FROM_EDIT,"Paste");

    AppendMenu(ViewMenu,MF_STRING,MAX_FROM_VIEW,    "Maximize       Ctrl+Up");
    AppendMenu(ViewMenu,MF_STRING,NOMR_FORM_VIEW,   "Normal View  Ctrl+Down");
    AppendMenu(HelpMenu,MF_STRING,INFO_FROM_HELP,   "Info    Ctrl+H");
    SetMenu(hwnd,myMenu);

  /*
    NONCLIENTMETRICS ncm;
	ncm.cbSize = sizeof(NONCLIENTMETRICS);
	SystemParametersInfo(SPI_GETNONCLIENTMETRICS, sizeof(NONCLIENTMETRICS), &ncm, 0);
	LOGFONT lfont = { 0 };
	lfont.lfHeight = 12;
	lfont.lfWeight = FW_MEDIUM;
	strcpy(lfont.lfFaceName, "Segoe UI");

	ncm.lfMenuFont = lfont;

	SystemParametersInfo(SPI_SETNONCLIENTMETRICS, sizeof(ncm), &ncm, 0);
	SendMessage(hwnd, WM_SETTINGCHANGE, 0, 0);
*/

return myMenu;
}

void HelpMessage(HWND hwnd){

    MessageBox(hwnd,"Lab nr 2","Info",MB_OK);
}

void SetBackgroundColor(HWND hwnd, HDC hdc, COLORREF color)
{
	RECT rect;
	HBRUSH bgBrushh = CreateSolidBrush(color);
	GetClientRect(hwnd, &rect);
	FillRect(hdc, &rect, bgBrushh);
	//InvalidateRect(hwnd,&rect,TRUE);
}
HWND CreateListBox(HWND hwnd){

}

HWND InitRedSB(HWND hwnd)
{
	HWND hScroll;
	hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_HORZ,
			10, 10, 255, 20, hwnd, (HMENU)RED_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 255, TRUE);
	SetScrollPos(hScroll, SB_CTL, 21, TRUE);
    return hScroll;}

HWND InitGreenSB(HWND hwnd){
    HWND hScroll;
	hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_HORZ,
			10, 40, 255, 20, hwnd, (HMENU)GREEN_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 255, TRUE);
	SetScrollPos(hScroll, SB_CTL, 45, TRUE);
    return hScroll;
}
HWND InitBlueSB(HWND hwnd){
    HWND hScroll;
	hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_HORZ,
			10, 70, 255, 20, hwnd, (HMENU)BLUE_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 255, TRUE);
	SetScrollPos(hScroll, SB_CTL, 201, TRUE);
	return hScroll;
}

HWND InitHeighScrollBar(HWND hwnd){
    HWND hScroll;
    hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_VERT,
			950, 200, 20, 150, hwnd, (HMENU)HEIGH_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 150, TRUE);
	SetScrollPos(hScroll, SB_CTL, 75, TRUE);
    return hScroll;
}

HWND InitWidthScrollBar(HWND hwnd){
    HWND hScroll;
    hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_HORZ,
			425, 600, 150, 20, hwnd, (HMENU)WIDTH_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 300, TRUE);
	SetScrollPos(hScroll, SB_CTL, 150, TRUE);
	return hScroll;
}
HWND HorizontallScroll(HWND hwnd)
{
    HWND hScroll;
    hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_HORZ | SBS_BOTTOMALIGN,
			425, 600, 150, 20, hwnd, (HMENU)HOR_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 300, TRUE);
	SetScrollPos(hScroll, SB_CTL, 150, TRUE);

}
HWND VerticallScroll(HWND hwnd){
    HWND hScroll;
    hScroll = CreateWindowEx(
			0, "scrollbar", NULL, WS_CHILD | WS_VISIBLE | SBS_VERT | SBS_RIGHTALIGN,
			CW_USEDEFAULT, CW_USEDEFAULT, 150, 20, hwnd, (HMENU)VER_SCROLL, NULL, NULL);
	SetScrollRange(hScroll, SB_CTL, 0, 300, TRUE);
	SetScrollPos(hScroll, SB_CTL, 150, TRUE);
}

int RandomNr(int minim, int maxim){
    return minim + (rand() * (int)(maxim - minim) / RAND_MAX);
}

int CalculateScrollPos(int initial_pos, WPARAM wParam)
{
	switch (LOWORD(wParam))
	{
	case SB_LINELEFT:
		return initial_pos - 1;
	case SB_LINERIGHT:
		return initial_pos + 1;
	case SB_THUMBPOSITION:
		return HIWORD(wParam);
	default:
		return NULL;
	}
}

HWND AddListBox(HWND hwnd)
{ //(0,255,255) (255, 228, 196) (138, 43, 226) (165, 42, 42) (95, 158, 160)
	const char *items[] = {"Aqua", "Bisque", "BlueViolet", "Brown", "CadetBlue"};
	HWND hwndList = CreateWindowEx( WS_EX_CLIENTEDGE, "listbox", NULL, WS_CHILD | WS_VISIBLE | WS_VSCROLL | ES_AUTOVSCROLL | LBS_STANDARD | LBS_NOTIFY, 10, 100, 150, 60, hwnd, (HMENU)IDLISTBOX, NULL, NULL);

	for (int i = 0; i < 5; i++)
	{
		int pos = (int)SendMessage(hwndList, LB_ADDSTRING, 0, (LPARAM)items[i]);
		SendMessage(hwndList, LB_SETITEMDATA, pos, (LPARAM)i);
	}

	return hwndList;
}
