singleton TSShapeConstructor(PlayerAnim_Disposition_BackDAE)
{
   baseShape = "./PlayerAnim_Disposition_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Back", "230", "249");
}
