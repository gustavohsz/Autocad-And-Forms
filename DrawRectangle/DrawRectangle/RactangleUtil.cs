﻿using System;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.EditorInput;
using System.Net;

namespace DrawRectangle
{
    public class RactangleUtil
    {

        [CommandMethod("DesenharRetangulo")]
        public void ShowRectangleForm()
        {
            RectangleForm rf = new RectangleForm();
            rf.Show();
        }

        public void DrawRectangle(double width, double height, Point3d insPt)
        {
            Document doc = Application.DocumentManager.MdiActiveDocument;
            Database db = doc.Database;
            Editor edt = doc.Editor;

            using (Transaction trans = db.TransactionManager.StartTransaction())
            {
                try
                {
                    doc.LockDocument();
                    BlockTable bt = trans.GetObject(db.BlockTableId, OpenMode.ForRead) as BlockTable;
                    BlockTableRecord btr = trans.GetObject(bt[BlockTableRecord.ModelSpace], OpenMode.ForWrite) as BlockTableRecord;

                    //Convert the insertionPoint to Point2d
                    Point2d insPt2d = new Point2d(insPt.X, insPt.Y);

                    //derive the upper left corner based on the insertion point
                    Point2d ulPt = new Point2d(insPt.X, insPt.Y+height);

                    //derive the upper right corner based on the upper left corner
                    Point2d urPt = new Point2d(ulPt.X+width, ulPt.Y);

                    //derive the lower right corner based on the insertion point
                    Point2d lrPt = new Point2d(insPt.X + width, insPt.Y);

                    //draw the LWPolyline using the newly derived vertices
                    Polyline pl = new Polyline();
                    pl.AddVertexAt(0, insPt2d, 0, 0, 0);
                    pl.AddVertexAt(1, ulPt, 0, 0, 0);
                    pl.AddVertexAt(2, urPt, 0, 0, 0);
                    pl.AddVertexAt(3, lrPt, 0, 0, 0);
                    pl.Closed = true;

                    btr.AppendEntity(pl);
                    trans.AddNewlyCreatedDBObject(pl, true);
                    trans.Commit();

                    edt.WriteMessage("Retângulo criado");

                }
                catch (System.Exception ex)
                {
                    edt.WriteMessage("Error encountered: " + ex.Message);
                    trans.Abort();
                }
            }

        }
    }
}
