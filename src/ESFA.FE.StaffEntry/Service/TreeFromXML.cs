using System;
using System.Windows.Forms;
using ESFA.DC.FEW.FileProcessingService.Model.Loose;
using Message = ESFA.DC.FEW.FileProcessingService.Model.Loose.Message;

namespace ESFA.FE.StaffEntry.Service
{
    public sealed class TreeFromXML
    {
        private readonly TreeView _tree;

        private ColumnToModelMapper _mapper;

        public TreeFromXML(TreeView tree, ColumnToModelMapper mapper)
        {
            _tree = tree;
            _mapper = mapper;
        }

        public void CreateTreeFromData(Message message)
        {
            _tree.Nodes.Clear();
            foreach (var staff in message.StaffData)
            {
                var node = _tree.Nodes.Add(GetName(staff));
                var type = staff.GetType();
                CreateNodeElements(node, staff);
            }
        }

        private void CreateNodeElements(TreeNode node, MessageStaffData staff)
        {
            throw new NotImplementedException();
        }

        private string GetName(MessageStaffData staff)
        {
            return $"{staff.FirstName} {staff.LastName}";
        }
    }
}
