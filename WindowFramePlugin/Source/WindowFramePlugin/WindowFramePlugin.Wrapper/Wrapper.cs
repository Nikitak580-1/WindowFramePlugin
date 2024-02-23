namespace WindowFramePlugin.Wrapper
{
    using System;
    using Kompas6API5;
    using Kompas6Constants3D;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Содержит атрибуты и методы для работы с API Компас-3D.
    /// </summary>
    public class Wrapper
    {
        /// <summary>
        /// Объект интерфейса API КОМПАС-3D.
        /// </summary>
        private KompasObject _object;

        /// <summary>
        /// Указатель на интерфейс документа.
        /// </summary>
        private ksDocument3D _document3D;

        /// <summary>
        ///  Указатель на интерфейс компонента.
        /// </summary>
        private ksPart _ksPart;

        /// <summary>
        ///  Указатель на интерфейс сущности.
        /// </summary>
        private ksEntity _ksEntity;

        /// <summary>
        ///  Указатель на интерфейс параметров эскиза.
        /// </summary>
        private ksSketchDefinition _ksSketchDefinition;

        /// <summary>
        ///  Указатель на эскиз.
        /// </summary>
        private ksDocument2D _ksDocument2D;

        /// <summary>
        /// Стиль линии.
        /// </summary>
        private const int _styleLine = 1;

        /// <summary>
        /// Строковое наименование идентификатора COM-объекта.
        /// </summary>
        private const string _kompas3DProgId = "KOMPAS.Application.5";

        /// <summary>
        /// Метод начала работы КОМПАС-3D.
        /// </summary>
        public void Start()
        {
            if (!IsKompasActive(out var kompas))
            {
                if (!IsKompasOpen(out kompas))
                {
                    throw new ArgumentException("Не удалось "
                                                + "открыть КОМПАС-3D.");
                }
            }

            kompas.Visible = true;
            kompas.ActivateControllerAPI();
            _object = kompas;
        }

        /// <summary>
        /// Запускает окно создания 3D-модели.
        /// </summary>
        public void CreateDocument3D()
        {
            _document3D = _object.Document3D();
            _document3D.Create();
            _ksPart = _document3D.GetPart((int)Part_Type.pTop_Part);
        }

        /// <summary>
        /// Создать эскиз с выбранной плоскостью.
        /// </summary>
        /// <param name="plane">Плоскость
        /// 1 - XY, 2 - XZ, 3 - YZ.</param>
        public ksEntity CreateSketch(int plane)
        {
            ksEntity currentPlane;

            if (plane == 1)
            {
                currentPlane =
                    (ksEntity)_ksPart.GetDefaultEntity(
                        (short)Obj3dType.o3d_planeXOY);
            }

            else if (plane == 2)
            {
                currentPlane =
                    (ksEntity)_ksPart.GetDefaultEntity(
                        (short)Obj3dType.o3d_planeXOZ);
            }

            else
            {
                currentPlane =
                    (ksEntity)_ksPart.GetDefaultEntity(
                        (short)Obj3dType.o3d_planeYOZ);
            }

            _ksEntity = (ksEntity)_ksPart.NewEntity(
                (short)Obj3dType.o3d_sketch);
            _ksSketchDefinition =
                (ksSketchDefinition)_ksEntity.GetDefinition();
            _ksSketchDefinition.SetPlane(currentPlane);
            _ksEntity.Create();

            return _ksEntity;
        }

        /// <summary>
        /// Создать эскиз со смещенной плоскостью.
        /// </summary>
        /// <param name="offset">Смещение.</param>
        /// <param name="plane">Плоскость.</param>
        public ksEntity CreateOffsetPlaneSketch(double offset, int plane)
        {
            ksEntity currentPlane =
                (ksEntity)_ksPart.NewEntity(
                    (short)Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition planeDefinition =
                (ksPlaneOffsetDefinition)currentPlane.GetDefinition();
            if (plane == 1)
            {
                planeDefinition.SetPlane(
                    _ksPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOY));
            }

            else if (plane == 2)
            {
                planeDefinition.SetPlane(
                    _ksPart.GetDefaultEntity((short)Obj3dType.o3d_planeXOZ));
            }

            else
            {
                planeDefinition.SetPlane(
                    _ksPart.GetDefaultEntity((short)Obj3dType.o3d_planeYOZ));
            }

            planeDefinition.direction = true;
            planeDefinition.offset = offset;
            currentPlane.Create();

            _ksEntity =
                (ksEntity)_ksPart.NewEntity((short)Obj3dType.o3d_sketch);
            _ksSketchDefinition =
                (ksSketchDefinition)_ksEntity.GetDefinition();
            _ksSketchDefinition.SetPlane(currentPlane);
            _ksEntity.Create();
            return _ksEntity;
        }

        /// <summary>
        /// Начать редактирование.
        /// </summary>
        public void BeginEdit()
        {
            _ksDocument2D = (ksDocument2D)_ksSketchDefinition.BeginEdit();
        }

        /// <summary>
        /// Закончить редактирование.
        /// </summary>
        public void EndEdit()
        {
            _ksSketchDefinition.EndEdit();
        }

        // <summary>
        /// Создать прямоугольник.
        /// </summary>
        /// <param name="x">Координата вершины прямоугольника в точке x</param>
        /// <param name="y">Координата вершины прямоугольника в точке y</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="height">Высота прямоугольника.</param>
        /// <param name="angle">Угол прямоугольника.</param>
        public void CreateRectangle(
            double x,
            double y,
            double width,
            double height,
            double angle)
        {
            var paramRectangle = (ksRectangleParam)_object.GetParamStruct(91);
            paramRectangle.x = x;
            paramRectangle.y = y;
            paramRectangle.width = width;
            paramRectangle.height = height;
            paramRectangle.ang = angle;
            paramRectangle.style = _styleLine;

            _ksDocument2D.ksRectangle(paramRectangle);
        }

        /// <summary>
        /// Выдавить по эскизу.
        /// </summary>
        /// <param name="ksEntitySketch">Эскиз.</param>
        /// <param name="depth">Глубина.</param>
        /// <param name="thin">Тонкостенный.</param>
        public void MakeExtrude(
            ksEntity ksEntitySketch, double depth)
        {
            var entityExtrude =
                (ksEntity)_ksPart.NewEntity(
                    (short)Obj3dType.o3d_baseExtrusion);
            var entityExtrudeDefinition =
                (ksBaseExtrusionDefinition)entityExtrude.GetDefinition();
            entityExtrudeDefinition.SetSideParam(
                true, 0, depth, 0, false);

            entityExtrudeDefinition.SetSketch(
                ksEntitySketch.GetDefinition());
            entityExtrude.Create();
        }

        /// <summary>
        /// Делает окно КОМПАС-3D активным.
        /// </summary>
        /// <param name="kompas">Объект КОМПАС-3D.</param>
        /// <returns>Является ли активным.</returns>
        private bool IsKompasActive(out KompasObject kompas)
        {
            kompas = null;

            try
            {
                kompas = (KompasObject)Marshal.
                    GetActiveObject(_kompas3DProgId);
                return true;
            }
            catch (COMException)
            {
                return false;
            }
        }

        /// <summary>
        /// Метод запускает КОМПАС-3D.
        /// </summary>
        /// <param name="kompas">Объект КОМПАС-3D.</param>
        /// <returns>Является ли запущенным.</returns>
        private bool IsKompasOpen(out KompasObject kompas)
        {
            try
            {
                var kompasType = Type.GetTypeFromProgID(_kompas3DProgId);
                kompas = (KompasObject)Activator.CreateInstance(kompasType);
                return true;
            }
            catch (COMException)
            {
                kompas = null;
                return false;
            }
        }
    }
}
