// inspect.cpp : Implementation of Cinspect

#include "stdafx.h"
#include "inspect.h"


// Cinspect

STDMETHODIMP Cinspect::inspect_component(BSTR path, BSTR* interfaces, BSTR* classes)
{
	ITypeLib*	typelib;
    ITypeInfo*	typeinfo;
    TYPEKIND	typekind;
    CComBSTR	className;
    CComBSTR	tmp_c;
    TYPEATTR*	typeattr;
    CComBSTR	interfaceName;
    CComBSTR	tmp_i;
    HREFTYPE	hreftype;
    ITypeInfo*	classtypeinfo;

    LoadTypeLibEx(path, REGKIND_NONE, &typelib);
    for (UINT i = 0;i < typelib->GetTypeInfoCount();++i) 
    {
        typelib->GetTypeInfoType(i, &typekind);
        if (typekind == TKIND_COCLASS)
        {
            typelib->GetTypeInfo(i, &typeinfo);
            typeinfo->GetDocumentation(MEMBERID_NIL, &className, NULL, NULL, NULL);
			tmp_c.Append(className);
			tmp_c.Append(";");
            typeinfo->GetTypeAttr(&typeattr);
            for (UINT j = 0;j < typeattr->cImplTypes;++j)
            {
                typeinfo->GetRefTypeOfImplType(j, &hreftype);
                typeinfo->GetRefTypeInfo(hreftype, &classtypeinfo);
                classtypeinfo->GetDocumentation(MEMBERID_NIL, &interfaceName, NULL, NULL, NULL);
				tmp_i.Append(interfaceName);
				tmp_i.Append(";");
            }
        }
    }
	*interfaces = tmp_i;
	*classes = tmp_c;
	return S_OK;
}

STDMETHODIMP Cinspect::count(BSTR path, LONG* nb_interfaces, LONG* nb_classes)
{
	ITypeLib*	typelib;
    ITypeInfo*	typeinfo;
    TYPEATTR*	typeattr;
	CComBSTR	className;
    TYPEKIND	typekind;

	*nb_interfaces = 0;
	*nb_classes = 0;

    LoadTypeLibEx(path, REGKIND_NONE, &typelib);
    for (UINT i = 0;i < typelib->GetTypeInfoCount();++i) 
    {
		typelib->GetTypeInfoType(i, &typekind);
        if (typekind == TKIND_COCLASS)
        {
			typelib->GetTypeInfo(i, &typeinfo);
			typeinfo->GetDocumentation(MEMBERID_NIL, &className, NULL, NULL, NULL);
			typeinfo->GetTypeAttr(&typeattr);

			*nb_classes = *nb_classes + 1;
			*nb_interfaces = *nb_interfaces + typeattr->cImplTypes;
        }
	}

	return S_OK;
}
