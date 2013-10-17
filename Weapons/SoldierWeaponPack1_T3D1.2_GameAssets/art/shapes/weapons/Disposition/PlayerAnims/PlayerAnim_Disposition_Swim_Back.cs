singleton TSShapeConstructor(PlayerAnim_Disposition_Swim_BackDAE)
{
   baseShape = "./PlayerAnim_Disposition_Swim_Back.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Swim_BackDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Swim_Back", "1390", "1449");
}
