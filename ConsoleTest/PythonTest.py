import clr
clr.AddReference('ProtoGeometry')
from Autodesk.DesignScript.Geometry import *

clr.AddReference('RevitAPI')
from Autodesk.Revit.DB import *

clr.AddReference('RevitServices')
from RevitServices.Persistence import DocumentManager
from RevitServices.Transactions import TrancsactionManager

clr.AddReference('RevitNode')
import Revit
clr.ImportExtensions(Revit.Elements)
clr.ImportExtensions(Revit.GeometryConversion)

dataEnteringNode = IN
listEle = IN[0]

def GetElementhasVerticé(listEle):
    out = []
    activeView  = Document.ActiveView
    for ele in listEle:
        ele =Element(s)
        option = Options()
        ele.get_Geometry();
        ele.get
    return out

Circle.ByThreePoints()


OUT = MapList(list1, list2)