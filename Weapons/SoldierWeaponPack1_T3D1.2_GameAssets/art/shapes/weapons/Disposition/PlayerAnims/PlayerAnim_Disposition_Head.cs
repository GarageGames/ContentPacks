singleton TSShapeConstructor(PlayerAnim_Disposition_HeadDAE)
{
   baseShape = "./PlayerAnim_Disposition_Head.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_HeadDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "false");
   %this.addSequence("ambient", "Head", "850", "860");
}
