singleton TSShapeConstructor(PlayerAnim_Disposition_Crouch_SideDAE)
{
   baseShape = "./PlayerAnim_Disposition_Crouch_Side.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_Crouch_SideDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Crouch_Side", "490", "519");
}
