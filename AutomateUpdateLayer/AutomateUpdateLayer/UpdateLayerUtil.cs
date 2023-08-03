using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;


namespace AutomateUpdateLayer
{
    public class UpdateLayerUtil
    {

        [CommandMethod("AtualizarLayer")]
        public void UpdateLayer()
        {
            LayerUpdateForm layerForm = new LayerUpdateForm();
            layerForm.ShowDialog();
        }

        public void ProcessLayerUpdate(string dwgPath, string oldLayer, string newLayer)
        {
            Document doc = Application.DocumentManager.Open(dwgPath);
            Database db = doc.Database;
            Editor edt = doc.Editor;

            doc.LockDocument();
            try
            {
                using (Transaction trans = db.TransactionManager.StartTransaction())
                {
                    TypedValue[] tv = new TypedValue[1];
                    tv.SetValue(new TypedValue((int)DxfCode.LayerName, oldLayer), 0);

                    SelectionFilter filter = new SelectionFilter(tv);
                    PromptSelectionResult psr = edt.SelectAll(filter);

                    if(psr.Status == PromptStatus.OK)
                    {
                        SelectionSet ss = psr.Value;
                        //loop through the selectionset and change the layer
                        foreach(SelectedObject sObj in ss)
                        {
                            if(sObj != null)
                            {
                                //create a new entity and assing the object to that entity
                                Entity ent = trans.GetObject(sObj.ObjectId, OpenMode.ForWrite) as Entity;
                                ent.Layer = newLayer;
                            }
                        }
                    }
                    else
                    {
                        edt.WriteMessage("\nNão há nenhum objeto selecionado.");
                    }

                    trans.Commit(); 

                }
                db.SaveAs(dwgPath, DwgVersion.Current);
                doc.CloseAndDiscard();

            }
            catch (Autodesk.AutoCAD.Runtime.Exception ex)
            {
                edt.WriteMessage("Erro encontrado: " + ex.Message);                               
            }

        }


    }
}
