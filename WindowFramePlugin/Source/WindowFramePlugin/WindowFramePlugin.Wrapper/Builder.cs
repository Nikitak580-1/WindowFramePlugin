namespace WindowFramePlugin.Wrapper
{
    using Kompas6API5;
    using WindowFramePlugin.Model;

    /// <summary>
    /// Класс построения оконной рамы.
    /// </summary>
    public class Builder
    {
        /// <summary>
        /// Объект класса для работы с API компаса.
        /// </summary>
        private readonly Wrapper _wrapper = new Wrapper();

        /// <summary>
        /// Начало координат.
        /// </summary>
        private PointDouble _center;

        /// <summary>
        /// Разница между длиной и высотой
        /// внутреннего прямоугольника и внешнего.
        /// </summary>
        private const double _difference = 5;

        /// <summary>
        /// Построить оконную раму.
        /// </summary>
        public void BuildWindowFrame(WindowFrameParameters parameters)
        {
            var centerX =
                parameters.GetParameterValue(ParameterType.WindowFrameLenghtW1) / 2;
            var centerY =
                parameters.GetParameterValue(ParameterType.WindowFrameHeightH2) / 2;
            _center = new PointDouble(-centerX, -centerY);
            _wrapper.Start();
            _wrapper.CreateDocument3D();
            ksEntity sketch = _wrapper.CreateSketch(1);
            _wrapper.BeginEdit();
            _wrapper.CreateRectangle(
                _center.X,
                _center.Y,
                parameters.GetParameterValue(ParameterType.WindowFrameLenghtW1),
                parameters.GetParameterValue(ParameterType.WindowFrameHeightH2),
                0);

            _wrapper.CreateRectangle(
                _center.X + (_difference / 2d),
                _center.Y + (_difference / 2d),
                parameters.GetParameterValue(ParameterType.WindowFrameLenghtW1) - _difference,
                parameters.GetParameterValue(ParameterType.WindowFrameHeightH2) - _difference,
                0);
            _wrapper.EndEdit();

            _wrapper.MakeExtrude(
                sketch,
                parameters.GetParameterValue(ParameterType.TotalWidthWindowFrameTh));

            var pointX =
                (parameters.GetParameterValue(
                    ParameterType.WindowFrameLenghtW1) / 2)
                         - (parameters.GetParameterValue(
                    ParameterType.LengthPartitionWindowFrameL3) / 2);

            var offset =
                parameters.GetParameterValue(ParameterType.TotalWidthWindowFrameTh)
                - parameters.GetParameterValue(ParameterType.TotalWidthWindowSashesTm);

            sketch = _wrapper.CreateOffsetPlaneSketch(offset, 1);
            _wrapper.BeginEdit();
            _wrapper.CreateRectangle(
                _center.X + pointX,
                _center.Y,
                parameters.GetParameterValue(ParameterType.LengthPartitionWindowFrameL3),
                parameters.GetParameterValue(ParameterType.WindowFrameHeightH2),
                0);
            _wrapper.EndEdit();

            _wrapper.MakeExtrude(
                sketch, parameters.GetParameterValue(ParameterType.TotalWidthWindowSashesTm));

            pointX =
                (parameters.GetParameterValue(
                    ParameterType.WindowFrameLenghtW1) / 2)
                + (parameters.GetParameterValue(
                    ParameterType.LengthPartitionWindowFrameL3) / 2);

            var pointY =
                parameters.GetParameterValue(
                             ParameterType.WindowFrameHeightH2)
                         - ((parameters.GetParameterValue(
                             ParameterType.WindowFrameHeightH2) * (9d / 10d))
                            - parameters.GetParameterValue(
                                ParameterType.TotalHeightWindowSashG2));

            offset =
                parameters.GetParameterValue(ParameterType.TotalWidthWindowFrameTh)
                - parameters.GetParameterValue(ParameterType.TotalWidthWindowSashesTm);

            sketch = _wrapper.CreateOffsetPlaneSketch(offset, 1);
            _wrapper.BeginEdit();
            _wrapper.CreateRectangle(
                _center.X + pointX,
                _center.Y + pointY,
                (parameters.GetParameterValue(ParameterType.WindowFrameLenghtW1) / 2)
                - (parameters.GetParameterValue(ParameterType.LengthPartitionWindowFrameL3) / 2),
                parameters.GetParameterValue(ParameterType.TotalHeightWindowSashG2),
                0);
            _wrapper.EndEdit();

            _wrapper.MakeExtrude(
                sketch, parameters.GetParameterValue(ParameterType.TotalWidthWindowSashesTm));
        }
    }
}
