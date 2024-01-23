
exports = open("Exports.cs","r")
write = ""
tmp_delegate = "\t\t\tdelegate* unmanaged[Cdecl, Stdcall]<IntPtr, void> @delegate = (delegate* unmanaged[Cdecl, Stdcall]<IntPtr, void>)RENAME; //Delegate Class was: CLASSNAME\n"
docontinue = 0
temp_w = ""
write_then_skip = 0

for ex in exports:
    if docontinue != 0:
        docontinue = docontinue-1
        continue
    if ex.__contains__("public static") and ex.__contains__("public"):
        print(ex)
        splitted = ex.split(", ")
        for spl in splitted:
            if spl.__contains__("public"):
                spl = spl.replace(")\n","")
                deleg = spl
                deleg_class = deleg.split(" ")[0]
                deleg_fn = deleg.split(" ")[1]
                temp_w = tmp_delegate.replace("RENAME",deleg_fn).replace("CLASSNAME",deleg_class)
                write_then_skip = 1
                ex = ex.replace(deleg.split(" ")[0],"IntPtr")
                write = write + ex
            #print(spl)
        
    else:
        if temp_w != "":
            if write_then_skip > 0:
                write = write + ex
                write_then_skip = write_then_skip - 1
            else:
                write = write + ex + temp_w
                temp_w = ""
                write_then_skip = 0
        else:
            write = write + ex
print("ok")

w = open("Exports_fix.cs","w")
w.write(write)
w.close()

print("ok fix")
